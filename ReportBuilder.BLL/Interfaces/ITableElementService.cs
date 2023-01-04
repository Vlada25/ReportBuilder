using ReportBuilder.BLL.DTO.TableElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.Interfaces
{
    public interface ITableElementService
    {
        Task<IEnumerable<TableElementDto>> GetAll();
        Task<TableElementDto> GetById(Guid id);
        Task<Guid> Create(TableElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(TableElementForUpdateDto entityForUpdate);
    }
}
