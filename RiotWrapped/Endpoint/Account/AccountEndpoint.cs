using System.Net;
using System.Text.Json;
using RiotWrapped.Common;
using RiotWrapped.Exception;
using RiotWrapped.Http;

namespace RiotWrapped.Endpoint.Account;

public interface IAccountEndpoint
{
    Task<AccountDto?> GetAccountByPuuidAsync(Region region, string puuid);
    Task<AccountDto?> GetAccountByRiotIdAsync(Region region, string gameName, string tagLine);
}

public class AccountEndpoint : IAccountEndpoint
{
    private readonly RestClient client;

    public AccountEndpoint(RestClient client)
    {
        this.client = client;
    }
    
    public async Task<AccountDto?> GetAccountByPuuidAsync(Region region, string puuid)
    {
        var response = await client.GetAsync<AccountDto>(region, $"/riot/account/v1/accounts/by-puuid/{puuid}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<AccountDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotWrappedException(response.StatusCode, response.Body)
        };
    }
    
    public async Task<AccountDto?> GetAccountByRiotIdAsync(Region region, string gameName, string tagLine)
    {
        var response = await client.GetAsync<AccountDto>(region, $"/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonSerializer.Deserialize<AccountDto>(response.Body),
            HttpStatusCode.NotFound => default,
            _ => throw new RiotWrappedException(response.StatusCode, response.Body)
        };
    }
}