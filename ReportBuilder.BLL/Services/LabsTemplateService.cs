using AutoMapper;
using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.BLL.Services
{
    public class LabsTemplateService : ILabsTemplateService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public LabsTemplateService(IRepositoryManager repositoryManager, IMapper mapper) 
        { 
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Guid> Create(LabsTemplateForCreationDto entityForCreation)
        {
            var entity = _mapper.Map<LabsTemplate>(entityForCreation);

            await _repositoryManager.LabsTemplateRepository.Create(entity);

            return entity.Id;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repositoryManager.LabsTemplateRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.LabsTemplateRepository.Delete(entity);
        }

        public async Task<IEnumerable<LabsTemplateDto>> GetAll() =>
            _mapper.Map<IEnumerable<LabsTemplateDto>>(await _repositoryManager.LabsTemplateRepository.GetAll(false));

        public async Task<LabsTemplateDto> GetById(Guid id)
        {
            var entity = await _repositoryManager.LabsTemplateRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            return _mapper.Map<LabsTemplateDto>(entity);
        }

        public async Task Update(LabsTemplateForUpdateDto entityForUpdate)
        {
            var entity = await _repositoryManager.LabsTemplateRepository.GetById(entityForUpdate.Id, true);
            _mapper.Map(entityForUpdate, entity);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.LabsTemplateRepository.Update(entity);
        }
    }
}
