using Microsoft.AspNetCore.HttpOverrides;
using RateLimit.Middlewares;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
// Add services to the container.

builder.Services.AddControllers();

//Radis Cache setting
var connectionString = builder.Configuration["Redis:ConnectionString"];

builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(connectionString));

var app = builder.Build();

// Enable Forwarded Headers Middleware
var options = new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
};
options.KnownNetworks.Clear(); // Clear default networks
options.KnownProxies.Clear();  // Clear default proxies

app.UseForwardedHeaders(options);

// Enable Swagger only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
app.UseMiddleware<RateLimiterMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//For Integration Tests
public partial class Program { }