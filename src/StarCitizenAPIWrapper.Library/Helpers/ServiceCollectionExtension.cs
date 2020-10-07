using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using StarCitizenAPIWrapper.Library.Services;

namespace StarCitizenAPIWrapper.Library.Helpers
{
    /// <summary>
    /// Extension for the <see cref="IServiceCollection"/> to use the <see cref="StarCitizenClient"/>.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="StarCitizenClient"/> to the service collection. This will call <see cref="System.Net.Http.IHttpClientFactory"/> if you have not registered the
        /// service already. If you wish to add this then call Microsoft.Extensions.DependencyInjection.AddHttpClient() with your configuration before using this.
        /// </summary>
        public static IServiceCollection AddStarCitizenClient(this IServiceCollection services)
        {
            if (!services.Any(x => x.ServiceType == typeof(IHttpClientFactory)))
            {
                services.AddHttpClient();
            }
            services.AddSingleton<IHttpClientService, HttpClientService>();
            services.TryAddTransient<IStarCitizenClient, StarCitizenClient>();

            return services;
        }
    }
}