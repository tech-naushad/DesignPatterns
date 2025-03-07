using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace RateLimitTests
{
    public class RateLimitControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public RateLimitControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task RateLimit_Success_WithinMax_Requests_Test()
        {
            var response = await _client.GetAsync("/api/RateLimit");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var content = await response.Content.ReadAsStringAsync();
            content.Should().Be("Succesful Service response");
        }

        /// <summary>
        /// API allowed max 5 request per client or ip address
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task RateLimit_Service_UnAvalibility_AfterMax_Requests_Test()
        {
            await Parallel.ForAsync(0, 5, async (i, cancellationToken) =>
            {
                var response = await _client.GetAsync("/api/RateLimit");
                response.EnsureSuccessStatusCode();
                if (i < 5)
                {
                    response.StatusCode.Should().Be(HttpStatusCode.OK);
                }
                else
                {
                    response.StatusCode.Should().Be(HttpStatusCode.TooManyRequests);
                    var content = await response.Content.ReadAsStringAsync();
                    content.Should().Be("Service unable to handle the requests. Try again later");
                }
            });            
        }
    }
}
