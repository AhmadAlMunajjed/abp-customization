using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Whyzr.Data
{
    /* This is used if database provider does't define
     * IWhyzrDbSchemaMigrator implementation.
     */
    public class NullWhyzrDbSchemaMigrator : IWhyzrDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}