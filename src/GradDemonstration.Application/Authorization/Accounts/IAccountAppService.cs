using System.Threading.Tasks;
using Abp.Application.Services;
using GradDemonstration.Authorization.Accounts.Dto;

namespace GradDemonstration.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
