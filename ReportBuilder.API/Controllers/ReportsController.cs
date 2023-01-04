using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReportBuilder.BLL;
using ReportBuilder.BLL.Domain;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Models;

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
        private readonly IMapper _mapper;

        public ReportsController(LabPdfWriter pdfWriter, ILabsTemplateService labsTemplateService, IMapper mapper)
        {
            _pdfWriter = pdfWriter;
            _labsTemplateService = labsTemplateService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument(string filename, int labNumber)
        {
            var labTemplate = await _labsTemplateService.GetByNumber(labNumber);

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
                LabsTemplate = labTemplate,
                PersonalData = personalData
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
