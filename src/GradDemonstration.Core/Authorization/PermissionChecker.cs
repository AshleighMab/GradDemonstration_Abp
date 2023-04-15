using Abp.Authorization;
using GradDemonstration.Authorization.Roles;
using GradDemonstration.Authorization.Users;

namespace GradDemonstration.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
