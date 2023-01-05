using ReportBuilder.DAL.Enums;

namespace ReportBuilder.BLL.DTO.PictureElement
{
    public class PictureElementForCreationDto
    {
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
        public int PictureNumber { get; set; }
    }
}
