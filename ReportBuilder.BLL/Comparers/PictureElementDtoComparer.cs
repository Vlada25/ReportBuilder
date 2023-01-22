using ReportBuilder.BLL.DTO.PictureElement;

namespace ReportBuilder.BLL.Comparers
{
    public class PictureElementDtoComparer : IComparer<PictureElementDto>
    {
        public int Compare(PictureElementDto x, PictureElementDto y)
        {
            if (x.Number > y.Number)
                return 1;
            else
                return -1;
        }
    }
}
