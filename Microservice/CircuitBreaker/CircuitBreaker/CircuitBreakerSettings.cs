namespace CircuitBreaker.CircuitBreaker
{
    public class CircuitBreakerSettings
    {
        public int HandledEventsAllowedBeforeBreaking { get; set; }
        public int DurationOfBreakInSeconds { get; set; }
    }
}
