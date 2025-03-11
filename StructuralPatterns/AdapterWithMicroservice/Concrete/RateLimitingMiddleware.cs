using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.Concrete
{
    public class RateLimitingMiddleware
    {
        private readonly RequestDelegate _next;

        public RateLimitingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task EnforceRateLimitAsync(HttpContext context)
        {
            var requestCount = context.Request.Headers["X-Request-Count"];
            if (int.TryParse(requestCount, out var count) && count > 5)
            {
                context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                await context.Response.WriteAsync("Rate Limit Exceeded");
                return;
            }

            await _next(context);
        }
    }

}
