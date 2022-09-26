// --------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollectionExtensions.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Shared.Core.Extensions;

namespace Modules.Identity.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdentityCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddExtendedAttributeHandlersFromAssembly(Assembly.GetExecutingAssembly());
            services.AddExtendedAttributeCommandValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddExtendedAttributePaginatedFilterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddPaginatedFilterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}