using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace RiotWrapped;

public class RiotClientConfiguration
{
    public required string ApiKey { get; init; }
    
    public ILoggerProvider LoggerProvider { get; init; } = NullLoggerProvider.Instance;
}