using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Whyzr
{
    [Dependency(ReplaceServices = true)]
    public class WhyzrBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Whyzr";
    }
}
