namespace CircuitBreaker.Services
{
    public interface IFankfurterService
    {
        public Task<string> GetLatestExchangeRateAsync(string baseCurrency);
    }
}
