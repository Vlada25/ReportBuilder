using ReportBuilder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.Interfaces.Repositories
{
    public interface ILabsTemplateRepository
    {
        Task<IEnumerable<LabsTemplate>> GetAll(bool trackChanges);
        Task<LabsTemplate> GetById(Guid id, bool trackChanges);
        Task Create(LabsTemplate entity);
        void Delete(LabsTemplate entity);
        void Update(LabsTemplate entity);
    }
}
