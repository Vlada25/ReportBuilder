using ReportBuilder.DAL.Models;

namespace ReportBuilder.BLL.Comparers
{
    public class ReportElementComparer : IComparer<ReportElement>
    {
        public int Compare(ReportElement? x, ReportElement? y)
        {
            if (x.Number > y.Number)
                return 1;
            else
                return -1;
        }
    }
}
