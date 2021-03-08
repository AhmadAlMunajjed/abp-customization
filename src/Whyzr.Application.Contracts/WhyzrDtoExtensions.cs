using System;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Whyzr.Users;

namespace Whyzr
{
    public static class WhyzrDtoExtensions
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                /* You can add extension properties to DTOs
                 * defined in the depended modules.
                 *
                 * Example:
                 *
                 * ObjectExtensionManager.Instance
                 *   .AddOrUpdateProperty<IdentityRoleDto, string>("Title");
                 *
                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Object-Extensions
                 */

                ObjectExtensionManager.Instance
                    .AddOrUpdateProperty<UserType>(
                        new[]
                        {
                            typeof(IdentityUserDto),
                            typeof(IdentityUserCreateDto),
                            typeof(IdentityUserUpdateDto)
                        },
                        "Type",
                        options =>
                        {

                        }
                    );

                ObjectExtensionManager.Instance
                    .AddOrUpdateProperty<Guid?>(
                        new[]
                        {
                            typeof(IdentityUserDto),
                            typeof(IdentityUserCreateDto),
                            typeof(IdentityUserUpdateDto)
                        },
                        "TypeId",
                        options =>
                        {

                        }
                    );

                ObjectExtensionManager.Instance
                    .AddOrUpdateProperty<string>(
                        new[]
                        {
                            typeof(IdentityUserDto),
                            typeof(IdentityUserCreateDto),
                        },
                        "AppName",
                        options =>
                        {
                        }
                    );
            });
        }
    }
}