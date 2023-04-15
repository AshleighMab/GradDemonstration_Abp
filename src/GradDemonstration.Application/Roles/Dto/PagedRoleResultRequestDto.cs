using Abp.Application.Services.Dto;

namespace GradDemonstration.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

