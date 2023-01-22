using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL.Repositories
{
    public class LabsTemplateRepository : ILabsTemplateRepository
    {
        private readonly AppDbContext _dbContext;
        public LabsTemplateRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(LabsTemplate entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(LabsTemplate entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<LabsTemplate>> GetAll(bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<LabsTemplate>().OrderBy(_ => _.Number).AsNoTracking()
                : _dbContext.Set<LabsTemplate>().OrderBy(_ => _.Number);

            return await list.ToListAsync();
        }

        public async Task<LabsTemplate> GetById(Guid id, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<LabsTemplate>().Where(x => x.Id.Equals(id)).AsNoTracking()
                : _dbContext.Set<LabsTemplate>().Where(x => x.Id.Equals(id));

            return await list.FirstOrDefaultAsync();
        }

        public async Task<LabsTemplate> GetByNumber(int number)
        {
            return await _dbContext.LabsTemplates.FirstAsync(x => x.Number == number);
        }

        public async Task Update(LabsTemplate entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
