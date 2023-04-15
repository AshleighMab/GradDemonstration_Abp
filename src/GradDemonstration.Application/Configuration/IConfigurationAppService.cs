using System.Threading.Tasks;
using GradDemonstration.Configuration.Dto;

namespace GradDemonstration.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
