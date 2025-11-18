using System.Collections.ObjectModel;

namespace SpotifyClone.Shared.Authorization;

public static class SpotifyClonePermissions
{
    private static readonly SpotifyClonePermission[] AllPermissions =
    [     
        //tenants
        new("View Tenants", SpotifyCloneActions.View, SpotifyCloneResources.Tenants, IsRoot: true),
        new("Create Tenants", SpotifyCloneActions.Create, SpotifyCloneResources.Tenants, IsRoot: true),
        new("Update Tenants", SpotifyCloneActions.Update, SpotifyCloneResources.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", SpotifyCloneActions.UpgradeSubscription, SpotifyCloneResources.Tenants, IsRoot: true),

        //identity
        new("View Users", SpotifyCloneActions.View, SpotifyCloneResources.Users),
        new("Search Users", SpotifyCloneActions.Search, SpotifyCloneResources.Users),
        new("Create Users", SpotifyCloneActions.Create, SpotifyCloneResources.Users),
        new("Update Users", SpotifyCloneActions.Update, SpotifyCloneResources.Users),
        new("Delete Users", SpotifyCloneActions.Delete, SpotifyCloneResources.Users),
        new("Export Users", SpotifyCloneActions.Export, SpotifyCloneResources.Users),
        new("View UserRoles", SpotifyCloneActions.View, SpotifyCloneResources.UserRoles),
        new("Update UserRoles", SpotifyCloneActions.Update, SpotifyCloneResources.UserRoles),
        new("View Roles", SpotifyCloneActions.View, SpotifyCloneResources.Roles),
        new("Create Roles", SpotifyCloneActions.Create, SpotifyCloneResources.Roles),
        new("Update Roles", SpotifyCloneActions.Update, SpotifyCloneResources.Roles),
        new("View RoleClaims", SpotifyCloneActions.View, SpotifyCloneResources.RoleClaims),
        new("Update RoleClaims", SpotifyCloneActions.Update, SpotifyCloneResources.RoleClaims),
        
        //audit
        new("View Audit Trails", SpotifyCloneActions.View, SpotifyCloneResources.AuditTrails),
    ];

    public static IReadOnlyList<SpotifyClonePermission> All { get; } = new ReadOnlyCollection<SpotifyClonePermission>(AllPermissions);
    public static IReadOnlyList<SpotifyClonePermission> Root { get; } = new ReadOnlyCollection<SpotifyClonePermission>(AllPermissions.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<SpotifyClonePermission> Admin { get; } = new ReadOnlyCollection<SpotifyClonePermission>(AllPermissions.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<SpotifyClonePermission> Basic { get; } = new ReadOnlyCollection<SpotifyClonePermission>(AllPermissions.Where(p => p.IsBasic).ToArray());
}

public record SpotifyClonePermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource)
    {
        return $"Permissions.{resource}.{action}";
    }
}


