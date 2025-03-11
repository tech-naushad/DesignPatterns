using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.Concrete
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task LogRequestAsync(HttpContext context)
        {
            Console.WriteLine($"Request URL: {context.Request.Path}");
            await _next(context);
        }
    }

}
