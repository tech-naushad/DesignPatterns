using Microsoft.AspNetCore.Http;

namespace StructuralPatterns.Decorator.Concrete
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task AuthenticateAsync(HttpContext context)
        {
            var isAuthenticated = context.Request.Headers.ContainsKey("Authorization");

            if (!isAuthenticated)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
                return;
            }

            await _next(context);
        }
    }

}
