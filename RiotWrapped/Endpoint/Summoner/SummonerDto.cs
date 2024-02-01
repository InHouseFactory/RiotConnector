using System.Text.Json.Serialization;

namespace RiotWrapped.Endpoint.Summoner;

public class SummonerDto
{
    [JsonPropertyName("id")] public required string Id { get; init; }

    [JsonPropertyName("accountId")] public required string AccountId { get; init; }

    [JsonPropertyName("puuid")] public required string Puuid { get; init; }

    [JsonPropertyName("name")] public required string Name { get; init; }

    [JsonPropertyName("profileIconId")] public required int ProfileIconId { get; init; }

    [JsonPropertyName("revisionDate")] public required long RevisionDate { get; init; }

    [JsonPropertyName("summonerLevel")] public required int SummonerLevel { get; init; }
}