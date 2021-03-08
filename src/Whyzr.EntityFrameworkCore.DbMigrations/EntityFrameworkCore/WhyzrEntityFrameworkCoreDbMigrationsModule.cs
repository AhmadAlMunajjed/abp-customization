using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Whyzr.EntityFrameworkCore
{
    [DependsOn(
        typeof(WhyzrEntityFrameworkCoreModule)
        )]
    public class WhyzrEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WhyzrMigrationsDbContext>();
        }
    }
}
