using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Linedata.DataMaintenance.Repository
{
    public class ServiceRepoHooks
    {
        public static void ConfigureRepoServices(IServiceCollection services, IConfiguration config)
        {


            //dbcontext
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("dbconn"));
            }, ServiceLifetime.Singleton);

            services.AddSingleton<ITools, Tools>();
            services.AddSingleton<ISecurityRepo, SecurityRepo>();
            services.AddSingleton<IIssuerRepo, IssuerRepo>();
        }
    }
}
