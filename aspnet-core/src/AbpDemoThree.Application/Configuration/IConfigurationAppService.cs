using System.Threading.Tasks;
using AbpDemoThree.Configuration.Dto;

namespace AbpDemoThree.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
