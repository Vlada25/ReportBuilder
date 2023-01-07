using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReportBuilder.DAL.Configuration;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }


        public DbSet<LabsTemplate> LabsTemplates { get; set; }
        public DbSet<ReportElement> ReportElements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LabsTemplateConfig());
            modelBuilder.ApplyConfiguration(new ParagraphElementConfig());
            modelBuilder.ApplyConfiguration(new PictureElementConfig());
            modelBuilder.ApplyConfiguration(new TableElementConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
        }
    }
}
