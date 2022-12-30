using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportBuilder.BLL;
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

        public ReportsController(LabPdfWriter pdfWriter)
        {
            _pdfWriter = pdfWriter;
        }

        [HttpPost]
        public IActionResult CreateDocument(string filename, int labNumber)
        {
            LabsTemplate labTemplate = new LabsTemplate
            {
                Number = 1,
                Theme = "Статические характеристики датчиков тока и напряжения",
                Purpose = "\n               1. Изучить принцип работы датчиков тока и напряжения\n" +
                        "               2. Исследовать статические характеристики датчиков тока и напряжения",
                Conclusion = "в ходе лабораторной работы изучил принцип работы датчиков тока и напряжения, а также на практике " +
                        "исследовал статические характеристики этих датчиков. По результатам  экспериментальных измерений было " +
                        "доказано, что зависимости измеряемых величин от входных значений имеют линейный характер, что облегчает съем " +
                        "измеряемых величин."
            };

            PersonalData personalData = new PersonalData
            {
                TeacherFullName = "Ковалев А.В.",
                StudentFullName = "Ермоленко А.А.",
                StudentGroup = "ПЭ-31",
            };

            _pdfWriter.CreateFile(_filepath + $"/{filename}.pdf", _fontpath, labTemplate, personalData);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDocument(string filename)
        {

            return NoContent();
        }
    }
}
