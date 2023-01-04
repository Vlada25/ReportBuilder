using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.DTO.ParagraphElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.Interfaces
{
    public interface IParagraphElementService
    {
        Task<IEnumerable<ParagraphElementDto>> GetAll();
        Task<ParagraphElementDto> GetById(Guid id);
        Task<Guid> Create(ParagraphElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(ParagraphElementForUpdateDto entityForUpdate);
    }
}
