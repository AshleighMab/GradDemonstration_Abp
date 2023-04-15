using System.Threading.Tasks;
using Abp.Application.Services;
using GradDemonstration.Sessions.Dto;

namespace GradDemonstration.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
