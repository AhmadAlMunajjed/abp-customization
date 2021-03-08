using Whyzr.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Whyzr
{
    [DependsOn(
        typeof(WhyzrEntityFrameworkCoreTestModule)
        )]
    public class WhyzrDomainTestModule : AbpModule
    {

    }
}