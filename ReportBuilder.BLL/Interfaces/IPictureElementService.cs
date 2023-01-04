using ReportBuilder.BLL.DTO.ParagraphElement;
using ReportBuilder.BLL.DTO.PictureElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.Interfaces
{
    public interface IPictureElementService
    {
        Task<IEnumerable<PictureElementDto>> GetAll();
        Task<PictureElementDto> GetById(Guid id);
        Task<Guid> Create(PictureElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(PictureElementForUpdateDto entityForUpdate);
    }
}
