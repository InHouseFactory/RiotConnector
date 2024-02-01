using System.Text.Json.Serialization;

namespace RiotWrapped.Endpoint.Account;

public sealed class AccountDto
{
    [JsonPropertyName("puuid")]
    public required string Puuid { get; init; }
    
    [JsonPropertyName("gameName")]
    public required string GameName { get; init; }
    
    [JsonPropertyName("tagLine")]
    public required string TagLine { get; init; }
}