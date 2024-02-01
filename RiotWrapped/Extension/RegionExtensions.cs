using RiotWrapped.Common;

namespace RiotWrapped.Extension;

public static class RegionExtensions
{
    private static readonly Dictionary<Region, string> regionDomains;
    private static readonly Dictionary<GameRegion, string> gameRegionDomains;

    static RegionExtensions()
    {
        regionDomains = new Dictionary<Region, string>
        {
            [Region.Europe] = "europe",
            [Region.Americas] = "americas",
            [Region.Asia] = "asia"
        };

        gameRegionDomains = new Dictionary<GameRegion, string>
        {
            [GameRegion.Euw] = "euw1",
            [GameRegion.Eune] = "eun1",
            [GameRegion.Na] = "na1",
            [GameRegion.Br] = "br1",
            [GameRegion.Lan] = "la1",
            [GameRegion.Oce] = "oc1",
            [GameRegion.Ru] = "ru",
            [GameRegion.Tr] = "tr1",
            [GameRegion.Jp] = "jp1",
            [GameRegion.Kr] = "kr"
        };
    }

    public static string GetDomain(this Region region)
    {
        return regionDomains[region];
    }

    public static string GetDomain(this GameRegion region)
    {
        return gameRegionDomains[region];
    }
}