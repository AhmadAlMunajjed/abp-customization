using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Whyzr.Data;
using Volo.Abp.DependencyInjection;

namespace Whyzr.EntityFrameworkCore
{
    public class EntityFrameworkCoreWhyzrDbSchemaMigrator
        : IWhyzrDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWhyzrDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WhyzrMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WhyzrMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}