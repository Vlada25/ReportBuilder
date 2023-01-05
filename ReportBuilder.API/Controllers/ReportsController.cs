using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportBuilder.BLL;
using ReportBuilder.BLL.Comparers;
using ReportBuilder.BLL.Domain;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Models;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly string _filepath = @"..\reports";
        private readonly string _fontpath = @"..\fonts\TimesNewRomanRegular.ttf";

        private readonly LabPdfWriter _pdfWriter;
        private readonly ILabsTemplateService _labsTemplateService;
        private readonly IParagraphElementService _paragraphElementService;
        private readonly IPictureElementService _pictureElementService;
        private readonly ITableElementService _tableElementService;
        private readonly IMapper _mapper;

        public ReportsController(LabPdfWriter pdfWriter,
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

        [HttpPost]
        public async Task<IActionResult> CreateDocument(string filename, int labNumber)
        {
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
                TeacherFullName = "Ковалев А.В.",
                StudentFullName = "Ермоленко А.А.",
                StudentGroup = "ПЭ-31",
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

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDocument(string filename)
        {

            return NoContent();
        }
    }
}
