using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace RiotWrapped;

public class RiotClientConfiguration
{
    public required string ApiKey { get; set; }
    
    public ILoggerProvider LoggerProvider { get; set; } = NullLoggerProvider.Instance;
}