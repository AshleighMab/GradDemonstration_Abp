using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace GradDemonstration.Authorization
{
    public class GradDemonstrationAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Products, L("Products"));
            context.CreatePermission(PermissionNames.Pages_Products_Create, L("ProductsCreate"));
            context.CreatePermission(PermissionNames.Pages_Products_Update, L("ProductsUpdate"));
            context.CreatePermission(PermissionNames.Pages_Products_Delete, L("ProductsDelete"));

            context.CreatePermission(PermissionNames.Pages_Person, L("Person"));
            context.CreatePermission(PermissionNames.Pages_Person_Create, L("PersonCreate"));
            context.CreatePermission(PermissionNames.Pages_Person_Update, L("PersonUpdate"));
            context.CreatePermission(PermissionNames.Pages_Person_Delete, L("PersonDelete"));

            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, GradDemonstrationConsts.LocalizationSourceName);
        }
    }
}
