using System.Diagnostics.CodeAnalysis;
using RiotWrapped.Common;

namespace RiotWrapped.Extension;

public static class RegionExtension
{
    private static readonly Dictionary<Region, string> domains;

    static RegionExtension()
    {
        domains = new Dictionary<Region, string>
        {
            [Region.Euw] = "euw1",
            [Region.Eune] = "br1",
            [Region.Na] = "na1",
            [Region.Eune] = "eun1",
            [Region.Ru] = "ru",
            [Region.Tr] = "tr1",
            [Region.Lan] = "la1",
            [Region.Las] = "la2",
            [Region.Oce] = "oc1",
        };
    }
    
    public static string GetDomain(this Region region) => domains[region];
}