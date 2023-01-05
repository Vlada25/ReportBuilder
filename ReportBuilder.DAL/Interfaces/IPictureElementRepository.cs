using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Interfaces
{
    public interface IPictureElementRepository
    {
        Task<IEnumerable<PictureElement>> GetAll(bool trackChanges);
        Task<PictureElement> GetById(Guid id, bool trackChanges);
        Task<IEnumerable<PictureElement>> GetByLabsTemplateId(Guid labsTemplateId, bool trackChanges);
        Task Create(PictureElement entity);
        Task Delete(PictureElement entity);
        Task Update(PictureElement entity);
    }
}
