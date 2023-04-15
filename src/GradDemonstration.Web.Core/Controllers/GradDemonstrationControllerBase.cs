using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GradDemonstration.Controllers
{
    public abstract class GradDemonstrationControllerBase: AbpController
    {
        protected GradDemonstrationControllerBase()
        {
            LocalizationSourceName = GradDemonstrationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
