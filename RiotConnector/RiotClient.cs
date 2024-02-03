using RiotConnector.Endpoint.Account;
using RiotConnector.Endpoint.League;
using RiotConnector.Endpoint.Summoner;
using RiotConnector.Http;

namespace RiotConnector;

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
        client = new RestClient(configuration);
    }

    public IAccountEndpoint Account => new AccountEndpoint(client);
    public ISummonerEndpoint Summoner => new SummonerEndpoint(client);
    public ILeagueEndpoint League => new LeagueEndpoint(client);
}