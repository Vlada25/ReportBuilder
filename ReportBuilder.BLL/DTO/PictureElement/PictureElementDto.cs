using Microsoft.AspNetCore.Http;
using ReportBuilder.BLL.DTO.ReportElement;

namespace ReportBuilder.BLL.DTO.PictureElement
{
    public class PictureElementDto : ReportElementDto
    {
        public int PictureNumber { get; set; }
        public string FileName { get; set; }
    }
}
