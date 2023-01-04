using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.BLL.Interfaces
{
    public interface ILabsTemplateService
    {
        Task<IEnumerable<LabsTemplateDto>> GetAll();
        Task<LabsTemplateDto> GetById(Guid id);
        Task<LabsTemplateDto> GetByNumber(int number);
        Task<Guid> Create(LabsTemplateForCreationDto entityForCreation);
        Task Delete(Guid id);
        Task Update(LabsTemplateForUpdateDto entityForUpdate);
    }
}
