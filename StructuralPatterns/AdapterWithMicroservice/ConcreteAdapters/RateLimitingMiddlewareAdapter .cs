using Microsoft.AspNetCore.Http;
using StructuralPatterns.Decorator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.ConcreteDecorators
{
    public class RateLimitingMiddlewareAdapter : IMiddleware
    {
        private readonly RateLimitingMiddleware _rateLimitingMiddleware;

        public RateLimitingMiddlewareAdapter(RateLimitingMiddleware rateLimitingMiddleware)
        {
            _rateLimitingMiddleware = rateLimitingMiddleware;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _rateLimitingMiddleware.EnforceRateLimitAsync(context);
        }
    }

}
