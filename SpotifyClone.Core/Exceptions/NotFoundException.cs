using System.Collections.ObjectModel;
using System.Net;

namespace SpotifyClone.Core.Exceptions;
public class NotFoundException : SpotifyCloneException
{
    public NotFoundException(string message)
        : base(message, new Collection<string>(), HttpStatusCode.NotFound)
    {
    }
}
