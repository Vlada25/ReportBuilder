using ReportBuilder.BLL.DTO.TableElement;

namespace ReportBuilder.BLL.Comparers
{
    public class TableElementDtoComparer : IComparer<TableElementDto>
    {
        public int Compare(TableElementDto x, TableElementDto y)
        {
            if (x.Number > y.Number)
                return 1;
            else
                return -1;
        }
    }
}
