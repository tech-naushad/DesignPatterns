using Microsoft.Extensions.Options;
using Polly.Extensions.Http;
using Polly;
 
namespace CircuitBreaker.CircuitBreaker
{    
    public class CircuitBreakerPolicy 
    {
        //private readonly IConfigurationBuilder _builder;
        public CircuitBreakerPolicy()
        {
            //_builder = builder;
        }
        public IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            //var connectionString = _builder.Configuration["AppSettings:ConnectionString"];
            //var connectionString = _builder.Configuration["AppSettings:ConnectionString"];

            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(
                    1,
                    TimeSpan.FromSeconds(30),
                    onBreak: (exception, timespan) =>
                    {
                        Console.WriteLine($"Circuit broken due to: {exception.Exception.Message}. Duration: {timespan}");
                        // Log to Application Insights or other tools
                    },
                    onReset: () =>
                    {
                        Console.WriteLine("Circuit reset to closed state.");
                    },
                    onHalfOpen: () =>
                    {
                        Console.WriteLine("Circuit in half-open state. Testing health...");
                    });
        }
    }
}
