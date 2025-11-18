using System.Net;

namespace SpotifyClone.Core.Exceptions;
public class SpotifyCloneException : Exception
{
    public IEnumerable<string> ErrorMessages { get; }

    public HttpStatusCode StatusCode { get; }

    public SpotifyCloneException(string message, IEnumerable<string> errors, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        : base(message)
    {
        ErrorMessages = errors;
        StatusCode = statusCode;
    }

    public SpotifyCloneException(string message) : base(message)
    {
        ErrorMessages = new List<string>();
    }
}
