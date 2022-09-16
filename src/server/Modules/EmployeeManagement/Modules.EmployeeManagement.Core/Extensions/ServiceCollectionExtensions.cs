using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.EmployeeManagement.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEmployeeManagementCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}