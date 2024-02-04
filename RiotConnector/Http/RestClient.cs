using RiotConnector.Enum;
using RiotConnector.Extension;

namespace RiotConnector.Http;

public class RestClient
{
    private readonly HttpClient client;

    public RestClient(RiotClientConfiguration configuration)
    {
        client = new HttpClient
        {
            DefaultRequestHeaders =
            {
                { "X-Riot-Token", configuration.ApiKey }
            }
        };
    }

    private async Task<RestResponse<T>> GetAsync<T>(string url)
    {
        var response = await SendAsync(new HttpRequestMessage(HttpMethod.Get, url));
        if (!response.IsSuccessStatusCode) return new RestResponse<T>(response.StatusCode);

        var content = await response.Content.ReadAsStringAsync();
        return new RestResponse<T>(response.StatusCode, content);
    }

    public async Task<RestResponse<T>> GetAsync<T>(Region region, string url)
    {
        return await GetAsync<T>($"https://{region.GetDomain()}.api.riotgames.com{url}");
    }

    public async Task<RestResponse<T>> GetAsync<T>(GameRegion region, string url)
    {
        return await GetAsync<T>($"https://{region.GetDomain()}.api.riotgames.com{url}");
    }

    private async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        var response = await client.SendAsync(request);
        return response;
    }
}