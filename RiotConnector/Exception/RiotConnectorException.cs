using System.Net;

namespace RiotConnector.Exception;

public class RiotConnectorException : System.Exception
{
    public RiotConnectorException(string message) : base(message)
    {
    }

    public RiotConnectorException(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; }
}