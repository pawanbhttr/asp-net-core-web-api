using ASPNETDemo.Infrastructure.Repository;
using ASPNETDemo.Shared.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETDemo.Infrastructure
{
    public static class RepositoryConfig
    {
        public static void RegisterDatabase(this IServiceCollection services)
        {
            services.AddSingleton<IRepository, MSSQLRepository>();
        }
    }
}
