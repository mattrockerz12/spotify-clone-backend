using System.Collections.ObjectModel;
using System.Net;

namespace SpotifyClone.Core.Exceptions;
public class UnauthorizedException : SpotifyCloneException
{
    public UnauthorizedException()
        : base("authentication failed", new Collection<string>(), HttpStatusCode.Unauthorized)
    {
    }
    public UnauthorizedException(string message)
       : base(message, new Collection<string>(), HttpStatusCode.Unauthorized)
    {
    }
}
