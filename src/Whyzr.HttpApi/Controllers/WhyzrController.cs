using Whyzr.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Whyzr.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WhyzrController : AbpController
    {
        protected WhyzrController()
        {
            LocalizationResource = typeof(WhyzrResource);
        }
    }
}