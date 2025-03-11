using Microsoft.AspNetCore.Http;
using StructuralPatterns.Decorator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.ConcreteDecorators
{
    public class LoggingMiddlewareAdapter : IMiddleware
    {
        private readonly LoggingMiddleware _loggingMiddleware;

        public LoggingMiddlewareAdapter(LoggingMiddleware loggingMiddleware)
        {
            _loggingMiddleware = loggingMiddleware;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _loggingMiddleware.LogRequestAsync(context);
        }
    }
}
