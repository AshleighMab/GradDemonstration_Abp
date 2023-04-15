using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GradDemonstration.Configuration.Dto;

namespace GradDemonstration.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GradDemonstrationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
