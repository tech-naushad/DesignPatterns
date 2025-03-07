using StackExchange.Redis;
using System.Net;

namespace RateLimit.Middlewares
{
    public class RateLimiterMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDatabase _redisDb;
        private readonly IConfiguration _configuration;
        private readonly int _limit;
        private readonly TimeSpan _period;
        public RateLimiterMiddleware(RequestDelegate next, IConnectionMultiplexer redis, IConfiguration config)
        {
            _next = next;
            _redisDb = redis.GetDatabase();
            _limit = int.Parse(config["RateLimit:Limit"]);
            _period = TimeSpan.Parse(config["RateLimit:Period"]);
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

            if (requestCount >= _limit)
            {
                context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
                await context.Response.WriteAsync("Service unable to handle the requests. Try again later");
                return;
            }
            await _redisDb.StringIncrementAsync(redisKey);
            _redisDb.KeyExpireAsync(redisKey, _period); //Cache till 1 minute set in appsetting

            await _next(context);

        }
    }
}
