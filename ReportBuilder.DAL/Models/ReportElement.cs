using ReportBuilder.DAL.Enums;

namespace ReportBuilder.DAL.Models
{
    public class ReportElement
    {
        public Guid Id { get; set; }
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
    }
}
