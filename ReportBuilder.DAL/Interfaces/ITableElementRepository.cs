using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Interfaces
{
    public interface ITableElementRepository
    {
        Task<IEnumerable<TableElement>> GetAll(bool trackChanges);
        Task<TableElement> GetById(Guid id, bool trackChanges);
        Task Create(TableElement entity);
        Task Delete(TableElement entity);
        Task Update(TableElement entity);
    }
}
