﻿using System.Runtime.Serialization;

namespace RiotConnector.Common;

public enum Division
{
    [EnumMember(Value = "I")] I,
    [EnumMember(Value = "II")] II,
    [EnumMember(Value = "III")] III,
    [EnumMember(Value = "IV")] IV
}