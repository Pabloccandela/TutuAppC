namespace TutuApp.ABP.Permissions;

public static class ABPPermissions
{
    public const string GroupName = "ABP";

    public static class Servicios
    {
        public const string Default = GroupName + ".Servicios";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
