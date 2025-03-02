using CircuitBreaker.CircuitBreaker;
using CircuitBreaker.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;
using Polly.CircuitBreaker;
using Polly.Extensions.Http;
using CircuitBreakerPolicy = CircuitBreaker.CircuitBreaker.CircuitBreakerPolicy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IFankfurterService, FankfurterService>();

builder.Services.Configure<CircuitBreakerSettings>(
    builder.Configuration.GetSection("CircuitBreaker"));


//var appSettings = app.Services.GetRequiredService<IOptions<AppSettings>>().Value;

builder.Services.AddHttpClient("FankfurterService", client =>
{
    client.BaseAddress = new Uri("https://api.frankfurter.app");
}).AddPolicyHandler(new CircuitBreakerPolicy().GetCircuitBreakerPolicy());

var app = builder.Build();

// Configure the HTTP request pipeline.
// Enable Swagger only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
 
 