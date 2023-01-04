using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Interfaces
{
    public interface IParagraphElementRepository
    {
        Task<IEnumerable<ParagraphElement>> GetAll(bool trackChanges);
        Task<ParagraphElement> GetById(Guid id, bool trackChanges);
        Task Create(ParagraphElement entity);
        Task Delete(ParagraphElement entity);
        Task Update(ParagraphElement entity);
    }
}
