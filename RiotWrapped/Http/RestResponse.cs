using System.Net;
using System.Text.Json;

namespace RiotWrapped.Http;

public class RestResponse<T>
{
    public string Body { get; }
    public HttpStatusCode StatusCode { get; }
    
    public RestResponse(HttpStatusCode statusCode, string rawBody)
    {
        this.StatusCode = statusCode;
        this.Body = rawBody;
    }
    
    public RestResponse(HttpStatusCode code) : this(code, string.Empty)
    {

    }
}