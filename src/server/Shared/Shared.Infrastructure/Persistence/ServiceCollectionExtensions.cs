// --------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollectionExtensions.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Core.Extensions;
using Shared.Core.Settings;

namespace Shared.Infrastructure.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseContext<T>(this IServiceCollection services)
            where T : DbContext
        {
            var options = services.GetOptions<PersistenceSettings>(nameof(PersistenceSettings));
            if (options.UsePostgres)
            {
                string connectionString = options.ConnectionStrings.Postgres;
                services.AddPostgres<T>(connectionString);
            }
            else if (options.UseMsSql)
            {
                string connectionString = options.ConnectionStrings.MSSQL;
                services.AddMSSQL<T>(connectionString);
            }

            return services;
        }

        private static IServiceCollection AddPostgres<T>(this IServiceCollection services, string connectionString)
            where T : DbContext
        {
            services.AddDbContext<T>(m => m.UseNpgsql(connectionString, e => e.MigrationsAssembly(typeof(T).Assembly.FullName)));
            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<T>();
            dbContext.Database.Migrate();
            services.AddHangfire(x => x.UsePostgreSqlStorage(connectionString));
            return services;
        }

        // ReSharper disable once InconsistentNaming
        private static IServiceCollection AddMSSQL<T>(this IServiceCollection services, string connectionString)
            where T : DbContext
        {
            services.AddDbContext<T>(m => m.UseSqlServer(connectionString, e => e.MigrationsAssembly(typeof(T).Assembly.FullName)));
            services.AddHangfire(x => x.UseSqlServerStorage(connectionString));
            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<T>();
            dbContext.Database.Migrate();

            return services;
        }
    }
}