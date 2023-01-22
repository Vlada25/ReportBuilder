using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReportBuilder.BLL;
using ReportBuilder.BLL.Comparers;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.BLL.Services;
using ReportBuilder.DAL.Models.ReportElements;
using ReportBuilder.DAL.Models;
using AutoMapper;
using ReportBuilder.API.Responses;
using Org.BouncyCastle.Asn1.X509.SigI;

namespace ReportBuilder.API.Controllers
{
    [Route("api/labsTemplates")]
    [ApiController]
    //[Authorize]
    public class LabsTemplateController : ControllerBase
    {
        private readonly ILabsTemplateService _labsTemplateService;
        private readonly IParagraphElementService _paragraphElementService;
        private readonly IPictureElementService _pictureElementService;
        private readonly ITableElementService _tableElementService;
        private readonly IMapper _mapper;

        public LabsTemplateController(ILabsTemplateService labsTemplateService,
            IParagraphElementService paragraphElementService,
            IPictureElementService pictureElementService,
            ITableElementService tableElementService,
            IMapper mapper)
        {
            _labsTemplateService = labsTemplateService;
            _paragraphElementService = paragraphElementService;
            _pictureElementService = pictureElementService;
            _tableElementService = tableElementService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetLabsTemplates()
        {
            return Ok(await _labsTemplateService.GetAll());
        }

        [HttpGet("data/{labNumber}")]
        public async Task<IActionResult> GetLabsData(int labNumber)
        {
            var labsTemplate = await _labsTemplateService.GetByNumber(labNumber);
            var pictures = await _pictureElementService.GetByLabsTemplateId(labsTemplate.Id);
            var tables = await _tableElementService.GetByLabsTemplateId(labsTemplate.Id);

            var pictureElements = pictures.ToList();
            pictureElements.Sort(new PictureElementDtoComparer());

            var tableElements = tables.ToList();
            tableElements.Sort(new TableElementDtoComparer());

            return Ok(new LabDataResponse
            {
                LabsTemplate = labsTemplate,
                PictureElements = pictureElements,
                TableElements = tableElements,
            });
        }
    }
}
