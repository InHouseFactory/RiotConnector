using System.Text.Json.Serialization;

namespace RiotWrapped.Endpoint.League;

public class MiniSeriesDto
{
    [JsonPropertyName("target")]
    public required int Target { get; init; }

    [JsonPropertyName("wins")]
    public required int Wins { get; init; }

    [JsonPropertyName("losses")]
    public required int Losses { get; init; }

    [JsonPropertyName("progress")]
    public required string Progress { get; init; }
}