# RiotConnector
RiotConnector is a .NET wrapper for the Riot Games API.  
It is designed to be easy to use and to provide a simple interface for interacting with the Riot Games API.  

  
### This library is still in development and is not yet feature complete.

## Installation
Using Package Manager
```shell
Install-Package RiotConnector
```

Using .NET CLI
```shell
dotnet add package RiotConnector
```

## Usage
```csharp
using RiotConnector;
using RiotConnector.Common;

var client = new RiotClient(new RiotClientConfiguration
{
    ApiKey = "YOUR_API_KEY_HERE"
});

var summoner = await client.Summoner.GetSummonerByNameAsync(GameRegion.Euw, "RiotWrapped");
if (summoner is null)
{
    return;
}

// Do something with the summoner
```

## Available Endpoints
- Account
- Summoner
- League


