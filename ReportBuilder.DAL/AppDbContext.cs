using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Configuration;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }


        public DbSet<LabsTemplate> LabsTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LabsTemplateConfig());
        }
    }
}
