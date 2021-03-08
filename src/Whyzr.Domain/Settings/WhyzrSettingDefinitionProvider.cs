using Volo.Abp.Settings;

namespace Whyzr.Settings
{
    public class WhyzrSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(WhyzrSettings.MySetting1));
        }
    }
}
