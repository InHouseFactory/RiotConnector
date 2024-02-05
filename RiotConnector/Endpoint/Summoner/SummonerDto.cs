using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RiotConnector.Endpoint.Summoner;

public class SummonerDto
{
    [JsonProperty("id")] public required string Id { get; init; }

    [JsonProperty("accountId")] public required string AccountId { get; init; }

    [JsonProperty("puuid")] public required string Puuid { get; init; }

    [JsonProperty("name")] public required string Name { get; init; }

    [JsonProperty("profileIconId")] public required int ProfileIconId { get; init; }

    [JsonProperty("revisionDate")] public required long RevisionDate { get; init; }

    [JsonProperty("summonerLevel")] public required int SummonerLevel { get; init; }
}