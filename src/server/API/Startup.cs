// --------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Identity.Extensions;
using Shared.Core.Extensions;
using Shared.Infrastructure.Extensions;

namespace Bootstrapper
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDistributedMemoryCache()
                .AddSerialization(_config)
                .AddSharedInfrastructure(_config)
                .AddIdentityModule(_config)
                .AddSharedApplication(_config);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSharedInfrastructure();
        }
    }
}