using AutoMapper;
using ReportBuilder.BLL.DTO.ParagraphElement;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.BLL.Services
{
    public class ParagraphElementService : IParagraphElementService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ParagraphElementService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Guid> Create(ParagraphElementForCreationDto entityForCreation)
        {
            var entity = _mapper.Map<ParagraphElement>(entityForCreation);

            await _repositoryManager.ParagraphElementRepository.Create(entity);

            return entity.Id;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repositoryManager.ParagraphElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.ParagraphElementRepository.Delete(entity);
        }

        public async Task<IEnumerable<ParagraphElementDto>> GetAll() =>
            _mapper.Map<IEnumerable<ParagraphElementDto>>(await _repositoryManager.ParagraphElementRepository.GetAll(false));

        public async Task<ParagraphElementDto> GetById(Guid id)
        {
            var entity = await _repositoryManager.ParagraphElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            return _mapper.Map<ParagraphElementDto>(entity);
        }

        public async Task<IEnumerable<ParagraphElementDto>> GetByLabsTemplateId(Guid labsTemplateId) =>
            _mapper.Map<IEnumerable<ParagraphElementDto>>(await _repositoryManager.ParagraphElementRepository.GetByLabsTemplateId(labsTemplateId, false));

        public async Task Update(ParagraphElementForUpdateDto entityForUpdate)
        {
            var entity = await _repositoryManager.ParagraphElementRepository.GetById(entityForUpdate.Id, true);
            _mapper.Map(entityForUpdate, entity);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.ParagraphElementRepository.Update(entity);
        }
    }
}
