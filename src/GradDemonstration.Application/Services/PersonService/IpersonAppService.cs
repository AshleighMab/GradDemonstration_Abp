using Abp.Application.Services;
using GradDemonstration.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Services.PersonService
{
    public interface IpersonAppService:IApplicationService
    {
        Task<PersonDto> CreateAsync(PersonDto input);
        Task<PersonDto> GetAsync(Guid id);
        Task<List<PersonDto>> GetAllAsync();
        Task<PersonDto> UpdateAsync(PersonDto input);
        Task Delete(Guid id);
    }
}
