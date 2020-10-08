using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("StarCitizenAPIWrapper.Library.Tests")] 
namespace StarCitizenAPIWrapper.Library.Services
{
    /// <summary>
    /// Http client service which will handle sending http requests
    /// </summary>
    public interface IHttpClientService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">URL to send request to</param>
        /// <returns></returns>
        /// <exception cref="StarCitizenAPIWrapper.Library.Services.HttpFailedRequestException">This exception will be thrown if you do not get a successful status code</exception>
        Task<string> Get(string url);
    }

    class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;
        
        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<string> Get(string url)
        {
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new HttpFailedRequestException(response.StatusCode, response.ReasonPhrase, url);

            return await response.Content.ReadAsStringAsync();
        }
    }

    class HttpFailedRequestException : Exception
    {
        public HttpFailedRequestException(HttpStatusCode statusCode, string reasonPhrase, string url)
            : this (GenerateGetException(statusCode, reasonPhrase, url))
        {
        }

        public HttpFailedRequestException(string message) : base(message)
        {
        }

        private static string GenerateGetException(HttpStatusCode statusCode, string reasonPhrase, string url)
        {
            return $"Status Code: {(int)statusCode} - Reason Phrase: {reasonPhrase} : URL: {url}";
        }
    }
}