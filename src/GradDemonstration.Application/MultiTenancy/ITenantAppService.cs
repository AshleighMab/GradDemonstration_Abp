using Abp.Application.Services;
using GradDemonstration.MultiTenancy.Dto;

namespace GradDemonstration.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

