using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.DAL.Repositories
{
    public class LabsTemplateRepository : ILabsTemplateRepository
    {
        public Task Create(LabsTemplate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LabsTemplate entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LabsTemplate>> GetAll(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<LabsTemplate> GetById(Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Update(LabsTemplate entity)
        {
            throw new NotImplementedException();
        }
    }
}
