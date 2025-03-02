using StackExchange.Redis;

namespace RateLimit.Middlewares
{
    public class RateLimiterMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDatabase _redisDb;
        public RateLimiterMiddleware(RequestDelegate next, IConnectionMultiplexer redis)
        {
            _next = next;
            _redisDb = redis.GetDatabase();
        }

        public async Task Invoke(HttpContext context)
        {
            string clientIP = context.Connection.RemoteIpAddress?.ToString();
            
            // Check if behind a proxy and use X-Forwarded-For
            if (context.Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                clientIP = context.Request.Headers["X-Forwarded-For"].ToString().Split(',')[0].Trim();
            }
            var redisKey = $"rate_limit:{clientIP}";

            var requestCount = (int)(await _redisDb.StringGetAsync(redisKey));

            if (requestCount >= 5)
            {
                context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                await context.Response.WriteAsync("Service unable to handle the requests. Try again later");
                return;
            }
            await _redisDb.StringIncrementAsync(redisKey);
            _redisDb.KeyExpireAsync(redisKey, TimeSpan.FromSeconds(60)); //Cache till 1 minute

            await _next(context);

        }
    }
}
