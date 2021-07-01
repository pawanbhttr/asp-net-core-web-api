using ASPNETDemo.Core.Interfaces;
using ASPNETDemo.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETDemo.Core
{
    public static class ServiceConfig
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}
