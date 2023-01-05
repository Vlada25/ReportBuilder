using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Repositories
{
    public class TableElementRepository : ITableElementRepository
    {
        private readonly AppDbContext _dbContext;
        public TableElementRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TableElement entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(TableElement entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TableElement>> GetAll(bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<TableElement>().AsNoTracking()
                : _dbContext.Set<TableElement>();

            return await list.ToListAsync();
        }

        public async Task<TableElement> GetById(Guid id, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<TableElement>().Where(x => x.Id.Equals(id)).AsNoTracking()
                : _dbContext.Set<TableElement>().Where(x => x.Id.Equals(id));

            return await list.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TableElement>> GetByLabsTemplateId(Guid labsTemplateId, bool trackChanges)
        {
            var list = !trackChanges
                ? _dbContext.Set<TableElement>().Where(x => x.LabTemplateId.Equals(labsTemplateId)).AsNoTracking()
                : _dbContext.Set<TableElement>().Where(x => x.LabTemplateId.Equals(labsTemplateId));

            return await list.ToListAsync();
        }

        public async Task Update(TableElement entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
