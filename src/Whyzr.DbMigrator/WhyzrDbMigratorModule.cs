using Whyzr.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Whyzr.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WhyzrEntityFrameworkCoreDbMigrationsModule),
        typeof(WhyzrApplicationContractsModule)
        )]
    public class WhyzrDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
