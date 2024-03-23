using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLConfig
{
    public class ConfigurationModule<T> :IConfigurationModule<T>
        where T : 
    {
        private readonly IServiceProvider _serviceProvider;

        public ConfigurationModule(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public static async Task DatabaseInit(this IServiceProvider serviceProvider, CancellationToken cancellationToken = default)
        {
            var scope = _serviceProvider.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            using var db = serviceProvider.GetRequiredService<T>();
            await db.Database.MigrateAsync(cancellationToken);
        }
    }
}
