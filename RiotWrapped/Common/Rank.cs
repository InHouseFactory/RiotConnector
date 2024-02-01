using System.Runtime.Serialization;

namespace RiotWrapped.Common;

public enum Rank
{
    [EnumMember(Value = "IRON")]
    Iron,
    [EnumMember(Value = "BRONZE")]
    Bronze,
    [EnumMember(Value = "SILVER")]
    Silver,
    [EnumMember(Value = "GOLD")]
    Gold,
    [EnumMember(Value = "PLATINUM")]
    Platinum,
    [EnumMember(Value = "EMERALD")]
    Emerald,
    [EnumMember(Value = "DIAMOND")]
    Diamond,
    [EnumMember(Value = "MASTER")]
    Master,
    [EnumMember(Value = "GRANDMASTER")]
    Grandmaster,
    [EnumMember(Value = "CHALLENGER")]
    Challenger
}