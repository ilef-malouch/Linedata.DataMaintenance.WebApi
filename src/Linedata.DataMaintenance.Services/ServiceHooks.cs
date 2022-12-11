using Linedata.DataMaintenance.Repository;
using Linedata.DataMaintenance.Shared.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Linedata.DataMaintenance.Services
{
    public class ServiceHooks
    {
        public static void ConfigureServices(IServiceCollection  services, IConfiguration config)
        {
            ServiceRepoHooks.ConfigureRepoServices(services, config);
            services.AddSingleton<ISecurityService, SecurityService>();
            services.AddSingleton<IIssuerService, IssuerService>();
            services.AddSingleton<IMapping, Mapping>();
        }
    }
}
