using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Repositories
{
    public class ParagraphElementRepository : IParagraphElementRepository
    {
        private readonly AppDbContext _dbContext;
        public ParagraphElementRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(ParagraphElement entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(ParagraphElement entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ParagraphElement>> GetAll(bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<ParagraphElement>().AsNoTracking()
                : _dbContext.Set<ParagraphElement>();

            return await list.ToListAsync();
        }

        public async Task<ParagraphElement> GetById(Guid id, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<ParagraphElement>().Where(x => x.Id.Equals(id)).AsNoTracking()
                : _dbContext.Set<ParagraphElement>().Where(x => x.Id.Equals(id));

            return await list.FirstOrDefaultAsync();
        }

        public async Task Update(ParagraphElement entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
