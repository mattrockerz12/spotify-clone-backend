using Ardalis.Specification;
using SpotifyClone.Core.Domain.Contracts;

namespace SpotifyClone.Core.Persistence;
public interface IRepository<T> : IRepositoryBase<T>
    where T : class, IAggregateRoot
{
}

public interface IReadRepository<T> : IReadRepositoryBase<T>
    where T : class, IAggregateRoot
{
}
