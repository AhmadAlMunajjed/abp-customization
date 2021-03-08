using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.Settings;
using Volo.Abp.Threading;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace Whyzr.Users
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IdentityUserManager))]
    public class UserManager : IdentityUserManager
    {
        public UserManager(
            IdentityUserStore store,
            IIdentityRoleRepository roleRepository,
            IIdentityUserRepository userRepository,
            IOrganizationUnitRepository organizationUnitRepository,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<IdentityUser> passwordHasher,
            IEnumerable<IUserValidator<IdentityUser>> userValidators,
            IEnumerable<IPasswordValidator<IdentityUser>> passwordValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors,
            IServiceProvider services,
            ILogger<IdentityUserManager> logger,
            ICancellationTokenProvider cancellationTokenProvider,
            ISettingProvider settingProvider) :
            base(store,
                roleRepository,
                userRepository,
                optionsAccessor,
                passwordHasher,
                userValidators,
                passwordValidators,
                keyNormalizer,
                errors,
                services,
                logger,
                cancellationTokenProvider,
                organizationUnitRepository,
                settingProvider
                )
        {
        }
    }
}
