using System.Collections.ObjectModel;
using SpotifyClone.Core.Audit;
using MediatR;

namespace SpotifyClone.Infrastructure.Identity.Audit;
public class AuditPublishedEvent : INotification
{
    public AuditPublishedEvent(Collection<AuditTrail>? trails)
    {
        Trails = trails;
    }
    public Collection<AuditTrail>? Trails { get; }
}
