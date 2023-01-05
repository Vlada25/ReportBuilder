using ReportBuilder.BLL.DTO.ParagraphElement;

namespace ReportBuilder.BLL.Interfaces
{
    public interface IParagraphElementService
    {
        Task<IEnumerable<ParagraphElementDto>> GetAll();
        Task<ParagraphElementDto> GetById(Guid id);
        Task<IEnumerable<ParagraphElementDto>> GetByLabsTemplateId(Guid labsTemplateId);
        Task<Guid> Create(ParagraphElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(ParagraphElementForUpdateDto entityForUpdate);
    }
}
