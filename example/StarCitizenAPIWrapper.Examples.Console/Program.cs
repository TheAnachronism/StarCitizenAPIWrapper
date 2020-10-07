using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarCitizenAPIWrapper.Library;
using StarCitizenAPIWrapper.Library.Helpers;

namespace StarCitizenAPIWrapper.ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var services = new ServiceCollection()
                .AddSingleton(config)
                .AddHttpClient()
                .AddStarCitizenClient()
                .BuildServiceProvider();

            var client = services.GetService<IStarCitizenClient>();

            var result = await client.GetStarmapObjectFromName("Stanton");
        }
    }
}
