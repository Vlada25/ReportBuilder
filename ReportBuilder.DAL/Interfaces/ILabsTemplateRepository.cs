using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL.Interfaces
{
    public interface ILabsTemplateRepository
    {
        Task<IEnumerable<LabsTemplate>> GetAll(bool trackChanges);
        Task<LabsTemplate> GetById(Guid id, bool trackChanges);
        Task<LabsTemplate> GetByNumber(int number);
        Task Create(LabsTemplate entity);
        Task Delete(LabsTemplate entity);
        Task Update(LabsTemplate entity);
    }
}
