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
