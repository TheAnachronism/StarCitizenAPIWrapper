using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarCitizenAPIWrapper.Library.Services;

namespace StarCitizenAPIWrapper.Library.Helpers
{
    /// <summary>
    /// Extension for the <see cref="IServiceCollection"/> to use the <see cref="StarCitizenClient"/>.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="AddStarCitizenApiLibrary"/> to the service collection.
        /// </summary>
        public static IServiceCollection AddStarCitizenApiLibrary(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<StarCitizenClientConfig>(config.GetSection(StarCitizenClientConfig.StarCitizenClient));
            //services.AddTransient<IHttpClientService, HttpClientService>();
            services.AddTransient<IStarCitizenClient, StarCitizenClient>();
            services.AddHttpClient<IHttpClientService, HttpClientService>();
            return services;
        }

    }
}