using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RiotConnector.Endpoint.League;

public class MiniSeriesDto
{
    [JsonProperty("target")] public required int Target { get; init; }

    [JsonProperty("wins")] public required int Wins { get; init; }

    [JsonProperty("losses")] public required int Losses { get; init; }

    [JsonProperty("progress")] public required string Progress { get; init; }
}