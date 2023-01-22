using AutoMapper;
using iTextSharp.text.pdf.parser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ReportBuilder.API.Requests;
using ReportBuilder.BLL;
using ReportBuilder.BLL.Comparers;
using ReportBuilder.BLL.Domain;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Models;
using ReportBuilder.DAL.Models.ReportElements;
using System.IO;

namespace ReportBuilder.API.Controllers
{
    [Route("api/reports")]
    [ApiController]
    //[Authorize]
    public class ReportController : ControllerBase
    {
        private readonly string _filepath = @"..\reports";
        private readonly string _picturesPath = @"..\pictures";
        private readonly string _fontpath = @"..\fonts\TimesNewRomanRegular.ttf";

        private readonly LabPdfWriter _pdfWriter;
        private readonly ILabsTemplateService _labsTemplateService;
        private readonly IParagraphElementService _paragraphElementService;
        private readonly IPictureElementService _pictureElementService;
        private readonly ITableElementService _tableElementService;
        private readonly IMapper _mapper;

        public ReportController(LabPdfWriter pdfWriter,
            ILabsTemplateService labsTemplateService,
            IParagraphElementService paragraphElementService,
            IPictureElementService pictureElementService,
            ITableElementService tableElementService,
            IMapper mapper)
        {
            _pdfWriter = pdfWriter;
            _labsTemplateService = labsTemplateService;
            _paragraphElementService = paragraphElementService;
            _pictureElementService = pictureElementService;
            _tableElementService = tableElementService;
            _mapper = mapper;
        }

        [HttpGet("pdfTemplate/{labNumber}")]
        public async Task<IActionResult> GetReportTemplate(int labNumber)
        {
            var filename = Guid.NewGuid();

            var labsTemplate = await _labsTemplateService.GetByNumber(labNumber);
            var paragraphs = await _paragraphElementService.GetByLabsTemplateId(labsTemplate.Id);
            var pictures = await _pictureElementService.GetByLabsTemplateId(labsTemplate.Id);
            var tables = await _tableElementService.GetByLabsTemplateId(labsTemplate.Id);

            List<ReportElement> reportElements = new List<ReportElement>();
            reportElements.AddRange(_mapper.Map<IEnumerable<ParagraphElement>>(paragraphs));
            reportElements.AddRange(_mapper.Map<IEnumerable<PictureElement>>(pictures));
            reportElements.AddRange(_mapper.Map<IEnumerable<TableElement>>(tables));
            reportElements.Sort(new ReportElementComparer());

            PersonalData personalData = new PersonalData
            {
                TeacherFullName = "<преподаватель>",
                StudentFullName = "<студент>",
                StudentGroup = "<группа>",
            };

            _pdfWriter.CreateFile(new PdfFileInfo
            {
                FilePath = _filepath + $"/{filename}.pdf",
                FontPath = _fontpath,
                LabsTemplate = labsTemplate,
                PersonalData = personalData,
                ReportElements = reportElements,
                ParagraphElements = paragraphs.ToList(),
                PictureElements = pictures.ToList(),
                TableElements = tables.ToList(),
            }, _mapper);

            byte[] fileArr = System.IO.File.ReadAllBytes(_filepath + $"/{filename}.pdf");

            return new FileContentResult(fileArr, new MediaTypeHeaderValue("application/pdf")) 
                {
                    FileDownloadName = $"template.pdf"
                };
        }

        [HttpPost("{labNumber}")]
        public async Task<IActionResult> CreateReport(int labNumber, ReportRequest reportRequest)
        {
            var filename = Guid.NewGuid();

            var labsTemplate = await _labsTemplateService.GetByNumber(labNumber);
            var paragraphs = await _paragraphElementService.GetByLabsTemplateId(labsTemplate.Id);
            var pictures = await _pictureElementService.GetByLabsTemplateId(labsTemplate.Id);
            var tables = await _tableElementService.GetByLabsTemplateId(labsTemplate.Id);

            foreach (var item in reportRequest.PictureElements)
            {
                pictures.FirstOrDefault(_ => _.PictureNumber == item.PictureNumber).FileName = item.FileName;
            }

            List<ReportElement> reportElements = new List<ReportElement>();
            reportElements.AddRange(_mapper.Map<IEnumerable<ParagraphElement>>(paragraphs));
            reportElements.AddRange(_mapper.Map<IEnumerable<PictureElement>>(pictures));
            reportElements.AddRange(_mapper.Map<IEnumerable<TableElement>>(tables));
            reportElements.Sort(new ReportElementComparer());

            _pdfWriter.CreateFile(new PdfFileInfo
            {
                FilePath = _filepath + $"/{filename}.pdf",
                PicturesPath = _picturesPath,
                FontPath = _fontpath,
                LabsTemplate = labsTemplate,
                PersonalData = reportRequest.PersonalData,
                ReportElements = reportElements,
                ParagraphElements = paragraphs.ToList(),
                PictureElements = pictures.ToList(),
                TableElements = tables.ToList(),
            }, _mapper);

            byte[] fileArr = System.IO.File.ReadAllBytes(_filepath + $"/{filename}.pdf");

            return new FileContentResult(fileArr, new MediaTypeHeaderValue("application/pdf"))
            {
                FileDownloadName = $"report.pdf"
            };
        }

        [HttpPost("pictures")] 
        public async Task<IActionResult> UploadPicture([FromForm] FileModel fileModel)
        {
            if (fileModel.File is null)
            {
                return BadRequest("File is invalid!");
            }

            var filename = Guid.NewGuid().ToString() + "." + fileModel.File.FileName.Split('.')[fileModel.File.FileName.Split('.').Length - 1];

            using (var fileStream = new FileStream($"{_picturesPath}\\{filename}", FileMode.Create))
            {
                await fileModel.File.CopyToAsync(fileStream);
            }

            return Ok(new { FileName = filename });
        }
    }
}
