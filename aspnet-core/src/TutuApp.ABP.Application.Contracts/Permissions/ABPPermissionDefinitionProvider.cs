using TutuApp.ABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TutuApp.ABP.Permissions;

public class ABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var ServicioStoreGroup = context.AddGroup(ABPPermissions.GroupName, L("Permission:ServiciosStore"));

        var ServiciosPermission = ServicioStoreGroup.AddPermission(ABPPermissions.Servicios.Default, L("Permission:Servicios"));
        ServiciosPermission.AddChild(ABPPermissions.Servicios.Create, L("Permission:Servicios.Create"));
        ServiciosPermission.AddChild(ABPPermissions.Servicios.Edit, L("Permission:Servicios.Edit"));
        ServiciosPermission.AddChild(ABPPermissions.Servicios.Delete, L("Permission:Servicios.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPResource>(name);
    }
}
