using ReportBuilder.DAL.Models;

namespace ReportBuilder.API.Requests
{
    public class ReportRequest
    {
        public PersonalData PersonalData { get; set; }
        public PictureElementRequest[] PictureElements { get; set; }
        public TableElementRequest[] TableElements { get; set; }
}
}
