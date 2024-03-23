using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PostgreSQLConfig
{
    public static class PostgresInitClass 
        where TInterface : class
        where T : DbContext, TInterface
    {
        public static IServiceCollection AddPostgreSQL<TInterface, T>(this IServiceCollection services, IConfiguration config)
           where TInterface : class
           where T : DbContext, TInterface
        {
            var databaseSettings = config.GetSection("DatabaseSettings");

            string? rootConnectionString = databaseSettings.GetRequiredSection("Connection").Value;

            if (string.IsNullOrEmpty(rootConnectionString))
            {
                throw new InvalidOperationException("DB ConnectionString is not configured.");
            }

            services.AddDbContext<T>((serviceProvider, options) =>
            {
                options.UseNpgsql(rootConnectionString, builder =>
                {
                    builder.MigrationsHistoryTable(HistoryRepository.DefaultTableName, databaseSettings.GetRequiredSection("DefaultSchema").Value);
                    builder.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds);
                    builder.EnableRetryOnFailure();
                    builder.MigrationsAssembly(typeof(T).Assembly.FullName);
                });
            });

            services.AddScoped<T>();
            services.AddScoped<TInterface, T>();

            return services;
        }
        public async Task Initialize<T>(CancellationToken cancellationToken)
            where T : DbContext
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<T>();
                await db.Database.MigrateAsync(cancellationToken);
            }
            
        }
    }
}
