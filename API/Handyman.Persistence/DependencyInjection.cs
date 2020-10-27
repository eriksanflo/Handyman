using Handyman.Service.Handler.ContextInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Handyman.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration config) 
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddDbContext<ProceduresDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProcedureDbContext>(provider => provider.GetService<ProceduresDbContext>());
        }
    }
}
