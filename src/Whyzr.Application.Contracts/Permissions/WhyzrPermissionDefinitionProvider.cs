using Whyzr.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Whyzr.Permissions
{
    public class WhyzrPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WhyzrPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(WhyzrPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WhyzrResource>(name);
        }
    }
}
