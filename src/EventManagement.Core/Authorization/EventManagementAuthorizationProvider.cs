using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace EventManagement.Authorization
{
    public class EventManagementAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Organiser, L("Organiser"));
            context.CreatePermission(PermissionNames.Pages_Particiant, L("Participant"));
            context.CreatePermission(PermissionNames.Pages_Events_View, L("Pages.Events.View"));
            context.CreatePermission(PermissionNames.Pages_Particiant_Apply, L("ParticipantApply"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Particiant_Events_Applied, L("ParticipantEventsApplied"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Particiant_Events_Delete, L("ParticipantEventsDelete"),multiTenancySides:MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, EventManagementConsts.LocalizationSourceName);
        }
    }
}
