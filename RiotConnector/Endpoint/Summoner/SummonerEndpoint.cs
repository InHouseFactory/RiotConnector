using System.Net;
using System.Text.Json;
using RiotConnector.Common;
using RiotConnector.Exception;
using RiotConnector.Http;

namespace RiotConnector.Endpoint.Summoner;

public interface ISummonerEndpoint
{
    Task<SummonerDto?> GetSummonerByNameAsync(GameRegion region, string summonerName);
    Task<SummonerDto?> GetSummonerByPuuidAsync(GameRegion region, string puuid);
    Task<SummonerDto?> GetSummonerByAccountIdAsync(GameRegion region, string accountId);
    Task<SummonerDto?> GetSummonerBySummonerIdAsync(GameRegion region, string summonerId);
}

public class SummonerEndpoint : ISummonerEndpoint
{
    private readonly RestClient client;

    public SummonerEndpoint(RestClient client)
    {
        this.client = client;
    }

    public async Task<SummonerDto?> GetSummonerByNameAsync(GameRegion region, string summonerName)
    {
        var response =
            await client.GetAsync<SummonerDto>(region, $"/riot/summoner/v1/summoners/by-name/{summonerName}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<SummonerDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotConnectorException(response.StatusCode, response.Body)
        };
    }

    public async Task<SummonerDto?> GetSummonerByPuuidAsync(GameRegion region, string puuid)
    {
        var response = await client.GetAsync<SummonerDto>(region, $"/riot/summoner/v1/summoners/by-puuid/{puuid}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<SummonerDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotConnectorException(response.StatusCode, response.Body)
        };
    }

    public async Task<SummonerDto?> GetSummonerByAccountIdAsync(GameRegion region, string accountId)
    {
        var response =
            await client.GetAsync<SummonerDto>(region, $"/riot/summoner/v1/summoners/by-account/{accountId}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<SummonerDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotConnectorException(response.StatusCode, response.Body)
        };
    }

    public async Task<SummonerDto?> GetSummonerBySummonerIdAsync(GameRegion region, string summonerId)
    {
        var response = await client.GetAsync<SummonerDto>(region, $"/riot/summoner/v1/summoners/{summonerId}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<SummonerDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotConnectorException(response.StatusCode, response.Body)
        };
    }
}