using Microsoft.AspNetCore.Mvc;

namespace RateLimit.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RateLimitController : ControllerBase
{  
    public RateLimitController()
    {
    }

    //Mimic the call to verify the number of requests 
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("Succesful Service response");   
    }
}
