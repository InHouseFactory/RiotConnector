using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotConnector.Enum;

namespace RiotConnector.Endpoint.League;

public class LeagueDto
{
    [JsonProperty("leagueId")] public required string LeagueId { get; init; }

    [JsonProperty("queueType")]
    [JsonConverter(typeof(StringEnumConverter))]
    public required QueueType QueueType { get; init; }

    [JsonProperty("tier")]
    [JsonConverter(typeof(StringEnumConverter))]
    public required Rank Rank { get; init; }

    [JsonProperty("name")] public required string Name { get; init; }

    [JsonProperty("entries")] public required List<LeagueEntryDto> Entries { get; init; }
}