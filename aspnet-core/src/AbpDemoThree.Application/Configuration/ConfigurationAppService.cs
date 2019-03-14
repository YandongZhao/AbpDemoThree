using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpDemoThree.Configuration.Dto;

namespace AbpDemoThree.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpDemoThreeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
