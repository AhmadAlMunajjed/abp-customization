using System;
using System.Collections.Generic;
using System.Text;
using Whyzr.Localization;
using Volo.Abp.Application.Services;

namespace Whyzr
{
    /* Inherit your application services from this class.
     */
    public abstract class WhyzrAppService : ApplicationService
    {
        protected WhyzrAppService()
        {
            LocalizationResource = typeof(WhyzrResource);
        }
    }
}
