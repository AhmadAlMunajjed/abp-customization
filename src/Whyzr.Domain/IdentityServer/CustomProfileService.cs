using IdentityServer4.Extensions;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer.AspNetIdentity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace Whyzr.IdentityServer
{
    public class CustomProfileService : AbpProfileService
    {
        public CustomProfileService(
            IdentityUserManager userManager,
            IUserClaimsPrincipalFactory<IdentityUser> claimsFactory,
            ICurrentTenant currentTenant) :
            base(userManager,
                claimsFactory,
                currentTenant)
        {
        }

        [UnitOfWork]
        public override async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            await base.GetProfileDataAsync(context);
            var tenantId = context.Subject.FindTenantId();
            using (CurrentTenant.Change(tenantId))
            {
                var userId = context.Subject.GetSubjectId();
                var user = await UserManager.FindByIdAsync(userId);
                
                if (context.IssuedClaims == null)
                {
                    context.IssuedClaims = new List<Claim>();
                }

                context.IssuedClaims.Add(new Claim("usertype", "superuser"));
                context.AddRequestedClaims(context.IssuedClaims);
            }
        }
    }

}
