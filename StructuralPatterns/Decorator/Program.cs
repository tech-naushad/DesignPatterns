using StructuralPatterns.Decorator.ConcreteDecorators;

namespace StructuralPatterns.Decorator
{
    public class Program
    {
        //Microservice code
        public static void Main(string[] args)
        {
            //Place the below code to Microservice Program.cs 


            //var builder = WebApplication.CreateBuilder(args);

            //// Register middlewares as singletons
            //builder.Services.AddSingleton<IMiddleware, AuthenticationMiddlewareAdapter>();
            //builder.Services.AddSingleton<IMiddleware, LoggingMiddlewareAdapter>();
            //builder.Services.AddSingleton<IMiddleware, RateLimitingMiddlewareAdapter>();

            //var app = builder.Build();

            //// Register middleware components in the pipeline
            //app.UseMiddleware<AuthenticationMiddlewareAdapter>();
            //app.UseMiddleware<LoggingMiddlewareAdapter>();
            //app.UseMiddleware<RateLimitingMiddlewareAdapter>();


            //app.Run();
        }        
         
    }
}
