using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpDemoThree.MultiTenancy.Dto;

namespace AbpDemoThree.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

