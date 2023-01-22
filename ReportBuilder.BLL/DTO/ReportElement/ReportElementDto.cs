using ReportBuilder.DAL.Enums;

namespace ReportBuilder.BLL.DTO.ReportElement
{
    public class ReportElementDto
    {
        public Guid Id { get; set; }
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
    }
}
