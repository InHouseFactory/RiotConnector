using System.Net;

namespace RiotWrapped.Exception;

public class RiotWrappedException : System.Exception
{
    public HttpStatusCode StatusCode { get; }
    
    public RiotWrappedException(string message) : base(message)
    {
    }
    
    public RiotWrappedException(HttpStatusCode statusCode, string message) : base(message)
    {
        this.StatusCode = statusCode;
    }
}