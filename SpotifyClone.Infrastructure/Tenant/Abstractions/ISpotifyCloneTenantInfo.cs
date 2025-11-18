using Finbuckle.MultiTenant.Abstractions;

namespace SpotifyClone.Infrastructure.Tenant.Abstractions;
public interface ISpotifyCloneTenantInfo : ITenantInfo
{
    string? ConnectionString { get; set; }
}
