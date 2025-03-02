using Microsoft.AspNetCore.Mvc;

namespace RateLimit.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RateLimitController : ControllerBase
{  
    public RateLimitController()
    {
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("Rate Limit Service response");   
    }
}
