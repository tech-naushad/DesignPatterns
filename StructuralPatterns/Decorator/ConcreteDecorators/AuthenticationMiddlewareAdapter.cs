using Microsoft.AspNetCore.Http;
using StructuralPatterns.Decorator.Concrete;

namespace StructuralPatterns.Decorator.ConcreteDecorators
{
    public class AuthenticationMiddlewareAdapter : IMiddleware
    {
        private readonly AuthenticationMiddleware _authenticationMiddleware;

        public AuthenticationMiddlewareAdapter(AuthenticationMiddleware authenticationMiddleware)
        {
            _authenticationMiddleware = authenticationMiddleware;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _authenticationMiddleware.AuthenticateAsync(context);
        }
    }

}
