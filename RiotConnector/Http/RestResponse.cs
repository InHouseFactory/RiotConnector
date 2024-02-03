using System.Net;

namespace RiotConnector.Http;

public class RestResponse<T>
{
    public RestResponse(HttpStatusCode statusCode, string rawBody)
    {
        StatusCode = statusCode;
        Body = rawBody;
    }

    public RestResponse(HttpStatusCode code) : this(code, string.Empty)
    {
    }

    public string Body { get; }
    public HttpStatusCode StatusCode { get; }
}