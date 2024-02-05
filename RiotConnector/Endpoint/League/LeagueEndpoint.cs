using System.Net;
using System.Text.Json;
using RiotConnector.Enum;
using RiotConnector.Exception;
using RiotConnector.Http;

namespace RiotConnector.Endpoint.League;

public interface ILeagueEndpoint
{
    Task<List<LeagueEntryDto>> GetLeagueEntriesBySummonerIdAsync(GameRegion region, string summonerId);
}

public class LeagueEndpoint : ILeagueEndpoint
{
    private readonly RestClient client;

    public LeagueEndpoint(RestClient client)
    {
        this.client = client;
    }

    public async Task<List<LeagueEntryDto>> GetLeagueEntriesBySummonerIdAsync(GameRegion region, string summonerId)
    {
        var response =
            await client.GetAsync<List<LeagueEntryDto>>(region, $"/lol/league/v4/entries/by-summoner/{summonerId}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<List<LeagueEntryDto>>(response.Body) ?? [],
            HttpStatusCode.NotFound => new List<LeagueEntryDto>(),
            _ => throw new RiotConnectorException(response.StatusCode, response.Body)
        };
    }
}