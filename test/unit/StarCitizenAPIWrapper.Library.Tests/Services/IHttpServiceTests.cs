using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using StarCitizenAPIWrapper.Library.Services;

namespace StarCitizenAPIWrapper.Library.Tests.Services
{
    public class IHttpServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task IHttpServiceTests_Get_Returns_Content_When_Successful()
        {
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("[{'id':1,'value':'1'}]"),
                })
                .Verifiable();
            
            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };
            IHttpClientService service = new HttpClientService(httpClient);
            
            var result = await service.Get("");
            
            Assert.NotNull(result);
        }

        [Test]
        public async Task IHttpServiceTests_Get_On_Not_Accesable_URL_Returns_HttpFailedRequestException()
        {
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent("[{'id':1,'value':'1'}]"),
                })
                .Verifiable();
            
            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };

            try
            {
                IHttpClientService service = new HttpClientService(httpClient);
                await service.Get("url");
            }
            catch (HttpFailedRequestException ex)
            {
                Assert.AreEqual("Status Code: 400 - Reason Phrase: Bad Request : URL: url", ex.Message);
                Assert.Pass();
            }
            catch (Exception)
            {
                Assert.Fail("Was not expecting a different exception");
            }

            Assert.Fail("Was expecting an execption of HttpFailedRequestException");
        }
    }
}