using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL.Repositories;

namespace ReportBuilder.DAL
{
    public class RepositoryManager : IRepositoryManager
    {
        private AppDbContext _dbContext;

        private ILabsTemplateRepository _labsTemplateRepository;
        private IParagraphElementRepository _paragraphElementRepository;
        private IPictureElementRepository _pictureElementRepository;
        private ITableElementRepository _tableElementRepository;

        public RepositoryManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IParagraphElementRepository ParagraphElementRepository
        {
            get
            {
                if (_paragraphElementRepository == null)
                {
                    _paragraphElementRepository = new ParagraphElementRepository(_dbContext);
                }
                return _paragraphElementRepository;
            }
        }

        public IPictureElementRepository PictureElementRepository
        {
            get
            {
                if (_pictureElementRepository == null)
                {
                    _pictureElementRepository = new PictureElementRepository(_dbContext);
                }
                return _pictureElementRepository;
            }
        }

        public ITableElementRepository TableElementRepository
        {
            get
            {
                if (_tableElementRepository == null)
                {
                    _tableElementRepository = new TableElementRepository(_dbContext);
                }
                return _tableElementRepository;
            }
        }

        public ILabsTemplateRepository LabsTemplateRepository
        {
            get
            {
                if (_labsTemplateRepository == null)
                {
                    _labsTemplateRepository = new LabsTemplateRepository(_dbContext);
                }
                return _labsTemplateRepository;
            }
        }
    }
}
