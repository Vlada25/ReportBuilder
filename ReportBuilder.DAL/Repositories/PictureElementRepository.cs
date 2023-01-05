using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Repositories
{
    public class PictureElementRepository : IPictureElementRepository
    {
        private readonly AppDbContext _dbContext;
        public PictureElementRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(PictureElement entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(PictureElement entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PictureElement>> GetAll(bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<PictureElement>().AsNoTracking()
                : _dbContext.Set<PictureElement>();

            return await list.ToListAsync();
        }

        public async Task<PictureElement> GetById(Guid id, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<PictureElement>().Where(x => x.Id.Equals(id)).AsNoTracking()
                : _dbContext.Set<PictureElement>().Where(x => x.Id.Equals(id));

            return await list.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PictureElement>> GetByLabsTemplateId(Guid labsTemplateId, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<PictureElement>().Where(x => x.LabTemplateId.Equals(labsTemplateId)).AsNoTracking()
                : _dbContext.Set<PictureElement>().Where(x => x.LabTemplateId.Equals(labsTemplateId));

            return await list.ToListAsync();
        }

        public async Task Update(PictureElement entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
