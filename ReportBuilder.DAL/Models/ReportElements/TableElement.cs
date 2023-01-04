namespace ReportBuilder.DAL.Models.ReportElements
{
    public class TableElement : ReportElement
    {
        public int TableNumber { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public string? VerticalTitles { get; set; }
        public string? HorizontalTitles { get; set; }
    }
}
