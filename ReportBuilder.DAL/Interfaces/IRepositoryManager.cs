using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.DAL.Interfaces
{
    public interface IRepositoryManager
    {
        public ILabsTemplateRepository LabsTemplateRepository { get; }
        public IParagraphElementRepository ParagraphElementRepository { get; }
        public IPictureElementRepository PictureElementRepository { get; }
        public ITableElementRepository TableElementRepository { get; }
    }
}
