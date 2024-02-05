using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RiotConnector.Endpoint.Account;

public sealed class AccountDto
{
    [JsonProperty("puuid")] public required string Puuid { get; init; }

    [JsonProperty("gameName")] public required string GameName { get; init; }

    [JsonProperty("tagLine")] public required string TagLine { get; init; }
}