using ReportBuilder.DAL.Enums;

namespace ReportBuilder.BLL.DTO.TableElement
{
    public class TableElementForCreationDto
    {
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
        public int TableNumber { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public string? VerticalTitles { get; set; }
        public string? HorizontalTitles { get; set; }
    }
}
