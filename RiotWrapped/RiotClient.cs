using RiotWrapped.Endpoint.Account;
using RiotWrapped.Endpoint.League;
using RiotWrapped.Endpoint.Summoner;
using RiotWrapped.Http;

namespace RiotWrapped;

public interface IRiotClient
{
    IAccountEndpoint Account { get; }
    ISummonerEndpoint Summoner { get; }
    ILeagueEndpoint League { get; }
}

public class RiotClient : IRiotClient
{
    private readonly RestClient client;
    
    public RiotClient(RiotClientConfiguration configuration)
    {
        this.client = new RestClient(configuration);
    }
    
    public IAccountEndpoint Account => new AccountEndpoint(client);
    public ISummonerEndpoint Summoner => new SummonerEndpoint(client);
    public ILeagueEndpoint League => new LeagueEndpoint(client);
}