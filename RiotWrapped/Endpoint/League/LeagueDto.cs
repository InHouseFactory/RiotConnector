using System.Text.Json.Serialization;
using RiotWrapped.Common;

namespace RiotWrapped.Endpoint.League;

public class LeagueDto
{
    [JsonPropertyName("leagueId")]
    public required string LeagueId { get; init; }

    [JsonPropertyName("queueType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required QueueType QueueType { get; init; }

    [JsonPropertyName("tier")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required Rank Rank { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("entries")]
    public required List<LeagueEntryDto> Entries { get; init; }
}