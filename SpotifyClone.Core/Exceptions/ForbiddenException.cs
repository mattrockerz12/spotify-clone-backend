using System.Net;

namespace SpotifyClone.Core.Exceptions;
public class ForbiddenException : SpotifyCloneException
{
    public ForbiddenException()
        : base("unauthorized", [], HttpStatusCode.Forbidden)
    {
    }
    public ForbiddenException(string message)
       : base(message, [], HttpStatusCode.Forbidden)
    {
    }
}
