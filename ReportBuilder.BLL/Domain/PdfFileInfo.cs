using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.DTO.ParagraphElement;
using ReportBuilder.BLL.DTO.PictureElement;
using ReportBuilder.BLL.DTO.TableElement;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.BLL.Domain
{
    public class PdfFileInfo
    {
        public string FilePath { get; set; }
        public string FontPath { get; set; }
        public LabsTemplateDto LabsTemplate { get; set; }
        public PersonalData PersonalData { get; set; }
        public List<ReportElement> ReportElements { get; set; }
        public List<ParagraphElementDto> ParagraphElements { get; set; }
        public List<PictureElementDto> PictureElements { get; set; }
        public List<TableElementDto> TableElements { get; set; }
    }
}
