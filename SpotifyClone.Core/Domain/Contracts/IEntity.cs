using SpotifyClone.Core.Domain.Events;
using System.Collections.ObjectModel;

namespace SpotifyClone.Core.Domain.Contracts;

public interface IEntity
{
    Collection<DomainEvent> DomainEvents { get; }
}

public interface IEntity<out TId> : IEntity
{
    TId Id { get; }
}
