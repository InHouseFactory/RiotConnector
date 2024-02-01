using System.Runtime.Serialization;

namespace RiotWrapped.Common;

public enum QueueType
{
    [EnumMember(Value = "RANKED_SOLO_5x5")]
    RankedSolo5x5,

    [EnumMember(Value = "RANKED_FLEX_SR")] RankedFlexSR
}