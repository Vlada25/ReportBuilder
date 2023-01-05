using AutoMapper;
using ReportBuilder.BLL.DTO.PictureElement;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.BLL.Services
{
    public class PictureElementService : IPictureElementService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public PictureElementService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Guid> Create(PictureElementForCreationDto entityForCreation)
        {
            var entity = _mapper.Map<PictureElement>(entityForCreation);

            await _repositoryManager.PictureElementRepository.Create(entity);

            return entity.Id;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repositoryManager.PictureElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.PictureElementRepository.Delete(entity);
        }

        public async Task<IEnumerable<PictureElementDto>> GetAll() =>
            _mapper.Map<IEnumerable<PictureElementDto>>(await _repositoryManager.PictureElementRepository.GetAll(false));

        public async Task<PictureElementDto> GetById(Guid id)
        {
            var entity = await _repositoryManager.PictureElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            return _mapper.Map<PictureElementDto>(entity);
        }

        public async Task<IEnumerable<PictureElementDto>> GetByLabsTemplateId(Guid labsTemplateId) =>
            _mapper.Map<IEnumerable<PictureElementDto>>(await _repositoryManager.PictureElementRepository.GetByLabsTemplateId(labsTemplateId, false));

        public async Task Update(PictureElementForUpdateDto entityForUpdate)
        {
            var entity = await _repositoryManager.PictureElementRepository.GetById(entityForUpdate.Id, true);
            _mapper.Map(entityForUpdate, entity);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.PictureElementRepository.Update(entity);
        }
    }
}
