using System.Net;
using System.Text.Json;
using RiotWrapped.Common;
using RiotWrapped.Exception;
using RiotWrapped.Http;

namespace RiotWrapped.Endpoint.League;

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
        var response = await client.GetAsync<List<LeagueEntryDto>>(region, $"/riot/league/v1/entries/by-summoner/{summonerId}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<List<LeagueEntryDto>>(response.Body) ?? [],
            HttpStatusCode.NotFound => new List<LeagueEntryDto>(),
            _ => throw new RiotWrappedException(response.StatusCode, response.Body)
        };
    }
}