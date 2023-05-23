namespace ReportBuilder.API.Requests
{
    public class TableElementRequest
    {
        public int TableNumber { get; set; }
        public string[][]? Values { get; set; }
    }
}
