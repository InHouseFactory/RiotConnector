using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotConnector.Enum;

namespace RiotConnector.Endpoint.League;

public class LeagueEntryDto
{
    [JsonProperty("summonerId")] public required string SummonerId { get; init; }

    [JsonProperty("summonerName")] public required string SummonerName { get; init; }

    [JsonProperty("queueType")]
    [JsonConverter(typeof(StringEnumConverter))]
    public required QueueType QueueType { get; init; }

    [JsonProperty("tier")]
    [JsonConverter(typeof(StringEnumConverter))]
    public required Rank Rank { get; init; }

    [JsonProperty("rank")]
    [JsonConverter(typeof(StringEnumConverter))]
    public required Division Division { get; init; }

    [JsonProperty("leaguePoints")] public required int LeaguePoints { get; init; }

    [JsonProperty("wins")] public required int Wins { get; init; }

    [JsonProperty("losses")] public required int Losses { get; init; }

    [JsonProperty("hotStreak")] public required bool HotStreak { get; init; }

    [JsonProperty("veteran")] public required bool Veteran { get; init; }

    [JsonProperty("freshBlood")] public required bool FreshBlood { get; init; }

    [JsonProperty("inactive")] public required bool Inactive { get; init; }

    [JsonProperty("miniSeries")] public MiniSeriesDto? MiniSeries { get; init; }
}