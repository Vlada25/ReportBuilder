using ReportBuilder.DAL.Enums;

namespace ReportBuilder.BLL.DTO.ParagraphElement
{
    public class ParagraphElementForCreationDto
    {
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
    }
}
