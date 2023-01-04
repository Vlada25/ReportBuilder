using Microsoft.AspNetCore.Identity;
using ReportBuilder.DAL.Interfaces;
using ReportBuilder.DAL;
using Microsoft.EntityFrameworkCore;
using ReportBuilder.BLL.Interfaces;
using ReportBuilder.BLL.Services;
using ReportBuilder.BLL;

namespace ReportBuilder.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
                    b.MigrationsAssembly("ReportBuilder.DAL")));
        }

        public static void ConfigureDbManagers(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<LabPdfWriter>();

            services.AddScoped<ILabsTemplateService, LabsTemplateService>();
            services.AddScoped<IParagraphElementService, ParagraphElementService>();
            services.AddScoped<IPictureElementService, PictureElementService>();
            services.AddScoped<ITableElementService, TableElementService>();
        }
    }
}
