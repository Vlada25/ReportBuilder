using AutoMapper;
using ReportBuilder.BLL.DTO.TableElement;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models;
using ReportBuilder.DAL.Models.ReportElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.Services
{
    public class TableElementService : ITableElementService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public TableElementService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<Guid> Create(TableElementForCreationDto entityForCreation)
        {
            var entity = _mapper.Map<TableElement>(entityForCreation);

            await _repositoryManager.TableElementRepository.Create(entity);

            return entity.Id;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repositoryManager.TableElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.TableElementRepository.Delete(entity);
        }

        public async Task<IEnumerable<TableElementDto>> GetAll() =>
            _mapper.Map<IEnumerable<TableElementDto>>(await _repositoryManager.TableElementRepository.GetAll(false));

        public async Task<TableElementDto> GetById(Guid id)
        {
            var entity = await _repositoryManager.TableElementRepository.GetById(id, false);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            return _mapper.Map<TableElementDto>(entity);
        }

        public async Task Update(TableElementForUpdateDto entityForUpdate)
        {
            var entity = await _repositoryManager.TableElementRepository.GetById(entityForUpdate.Id, true);
            _mapper.Map(entityForUpdate, entity);

            if (entity == null)
            {
                throw new NullReferenceException("Entity is not found");
            }

            await _repositoryManager.TableElementRepository.Update(entity);
        }
    }
}
