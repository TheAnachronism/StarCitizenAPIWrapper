# StarCitizenAPIWrapper
C# Wrapper around the StarCitizen API at\
https://starcitizen-api.com/

## Skipped API endpoints
The API has a telemetry endpoint. But I never understood the reason for that one.
After asking a developer about it, they told me, that this enpoint was never used.
Because of that I skipped that one. If it should be requested, create an issue and I'll see what I can do.

## Configure the service in DI
In order to use this service it requires some configuration in the .NET Core DI. A service collection extension is created for you to call in order to configure the services as shown below:

```
var services = new ServiceCollection()
    .AddStarCitizenApiLibrary(config)
    ...
    .BuildServiceProvider();
```
Please note: ```IConfiguration``` is required and does need to be passed through. This services requires the following configuration:

```
"StarCitizenClient" : {
    "ApiKey": "xxx",
    "ApiRequestUrl": "https://api.starcitizen-api.com/{0}/v1/eager/{1}",
    "ApiLiveRequestUrl": "https://api.starcitizen-api.com/{0}/v1/live/{1}",
    "ApiCacheRequestUrl": "https://api.starcitizen-api.com/{0}/v1/cache/{1}"
  }
```

## Feel free to contribute via a pull request

## NuGet package
https://www.nuget.org/packages/StarCitizenAPIWrapper/