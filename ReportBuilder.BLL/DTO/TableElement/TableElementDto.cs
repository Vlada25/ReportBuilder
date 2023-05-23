using ReportBuilder.BLL.DTO.ReportElement;
using ReportBuilder.DAL.Enums;

namespace ReportBuilder.BLL.DTO.TableElement
{
    public class TableElementDto : ReportElementDto
    {
        public int TableNumber { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public string? VerticalTitles { get; set; }
        public string? HorizontalTitles { get; set; }
        public string[][]? Values { get; set; }
    }
}
