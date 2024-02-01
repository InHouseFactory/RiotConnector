using System.Net;

namespace RiotWrapped.Exception;

public class RiotWrappedException : System.Exception
{
    public RiotWrappedException(string message) : base(message)
    {
    }

    public RiotWrappedException(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; }
}