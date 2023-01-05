using ReportBuilder.BLL.DTO.PictureElement;

namespace ReportBuilder.BLL.Interfaces
{
    public interface IPictureElementService
    {
        Task<IEnumerable<PictureElementDto>> GetAll();
        Task<PictureElementDto> GetById(Guid id);
        Task<IEnumerable<PictureElementDto>> GetByLabsTemplateId(Guid labsTemplateId);
        Task<Guid> Create(PictureElementForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(PictureElementForUpdateDto entityForUpdate);
    }
}
