using System.Text.Json.Serialization;
using RiotWrapped.Common;

namespace RiotWrapped.Endpoint.League;

public class LeagueEntryDto
{
    [JsonPropertyName("summonerId")] public required string SummonerId { get; init; }

    [JsonPropertyName("summonerName")] public required string SummonerName { get; init; }

    [JsonPropertyName("queueType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required QueueType QueueType { get; init; }

    [JsonPropertyName("tier")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required Rank Rank { get; init; }

    [JsonPropertyName("rank")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required Division Division { get; init; }

    [JsonPropertyName("leaguePoints")] public required int LeaguePoints { get; init; }

    [JsonPropertyName("wins")] public required int Wins { get; init; }

    [JsonPropertyName("losses")] public required int Losses { get; init; }

    [JsonPropertyName("hotStreak")] public required bool HotStreak { get; init; }

    [JsonPropertyName("veteran")] public required bool Veteran { get; init; }

    [JsonPropertyName("freshBlood")] public required bool FreshBlood { get; init; }

    [JsonPropertyName("inactive")] public required bool Inactive { get; init; }

    [JsonPropertyName("miniSeries")] public MiniSeriesDto? MiniSeries { get; init; }
}