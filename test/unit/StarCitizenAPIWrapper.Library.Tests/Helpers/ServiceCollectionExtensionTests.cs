using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;
using StarCitizenAPIWrapper.Library.Helpers;
using StarCitizenAPIWrapper.Library.Services;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace StarCitizenAPIWrapper.Library.Tests.Helpers
{
    public class ServiceCollectionExtensionTests
    {
        [Test]
        public void ServiceCollectionExtensionTests_Given_Extension_Ran_Add_IHttpClientService_Service()
        {
            IConfiguration config = new ConfigurationBuilder() 
                .Build();
                
            var services = new ServiceCollection()
                .AddStarCitizenApiLibrary(config)
                .BuildServiceProvider();
            
            Assert.NotNull(services.GetService<IHttpClientService>());
        }

        [Test]
        public void ServiceCollectionExtensionTests_Given_Extension_Ran_Add_IStarCitizenClient_Service()
        {
            IConfiguration config = new ConfigurationBuilder() 
                .Build();

            var services = new ServiceCollection()
                .AddStarCitizenApiLibrary(config)
                .BuildServiceProvider();
            
            Assert.NotNull(services.GetService<IStarCitizenClient>());
        }

        [Test]
        public void ServiceCollectionExtensionTests_Given_Extension_Ran_Add_IHttpClientFactory_Service()
        {
            IConfiguration config = new ConfigurationBuilder() 
                .Build();

            var services = new ServiceCollection()
                .AddStarCitizenApiLibrary(config)
                .BuildServiceProvider();
            
            Assert.NotNull(services.GetService<IHttpClientFactory>());
        }

        [Test]
        public void ServiceCollectionExtensionTests_Given_Extension_Ran_Add_StarCitizenClientConfig()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
                
            var services = new ServiceCollection()
                .AddStarCitizenApiLibrary(config)
                .BuildServiceProvider();
        }
    }
}