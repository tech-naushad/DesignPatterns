
using System.Net;

namespace CircuitBreaker.Services
{
    public class FankfurterService : IFankfurterService
    {
        private readonly HttpClient _httpClient;
        public FankfurterService(IHttpClientFactory httpClientFactory = null)
        {
            _httpClient = httpClientFactory.CreateClient("FankfurterService");
        }
        public async Task<string> GetLatestExchangeRateAsync(string baseCurrency)
        {
            // var response = await _httpClient.GetAsync($"https://api.frankfurter.app/latest1?base={baseCurrency}");

             
            var response = await _httpClient.GetAsync($"/latest1?base={baseCurrency}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
