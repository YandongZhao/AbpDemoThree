using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemoThree.Sessions.Dto;

namespace AbpDemoThree.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
