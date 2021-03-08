using Volo.Abp.Modularity;

namespace Whyzr
{
    [DependsOn(
        typeof(WhyzrApplicationModule),
        typeof(WhyzrDomainTestModule)
        )]
    public class WhyzrApplicationTestModule : AbpModule
    {

    }
}