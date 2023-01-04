using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.BLL.Interfaces
{
    public interface ILabsTemplateService
    {
        Task<IEnumerable<LabsTemplateDto>> GetAll();
        Task<IEnumerable<LabsTemplateDto>> Get(int rowsCount, string cacheKey);
        Task<LabsTemplateDto> GetById(Guid id);
        Task<LabsTemplateDto> Create(LabsTemplateForCreationDto entityForCreation);
        Task<bool> Delete(Guid id);
        Task<bool> Update(LabsTemplateForUpdateDto entityForUpdate);
    }
}
