using ReportBuilder.BLL.DTO.TableElement;

namespace ReportBuilder.BLL.Interfaces
{
    public interface ITableElementService
    {
        Task<IEnumerable<TableElementDto>> GetAll();
        Task<TableElementDto> GetById(Guid id);
        Task<IEnumerable<TableElementDto>> GetByLabsTemplateId(Guid labsTemplateId);
        Task<Guid> Create(TableElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(TableElementForUpdateDto entityForUpdate);
    }
}
