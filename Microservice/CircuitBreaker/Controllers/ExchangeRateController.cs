using CircuitBreaker.Services;
using Microsoft.AspNetCore.Mvc;

namespace CircuitBreaker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangeRateController : ControllerBase
    {
        private readonly ILogger<ExchangeRateController> _logger;
        private readonly IFankfurterService _fankfurterService;

        public ExchangeRateController(IFankfurterService fankfurterService)
        {
            _fankfurterService = fankfurterService;
        }

        [HttpGet("latest/{baseCurrency}")]
        public async Task<IActionResult> GetLastestRateAsync(string baseCurrency)
        {
            var cartDetails = await _fankfurterService.GetLatestExchangeRateAsync(baseCurrency);
            return Ok(cartDetails);
        }
    }
}
