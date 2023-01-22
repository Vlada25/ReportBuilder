using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.DTO.PictureElement;
using ReportBuilder.BLL.DTO.TableElement;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.API.Responses
{
    public class LabDataResponse
    {
        public LabsTemplateDto LabsTemplate { get; set; }
        public List<ReportElement> ReportElements { get; set; }
        public List<PictureElementDto> PictureElements { get; set; }
        public List<TableElementDto> TableElements { get; set; }
    }
}
