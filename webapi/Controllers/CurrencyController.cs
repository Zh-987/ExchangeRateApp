using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TrackingCzechExchangeRates.Application.Services;

namespace webapi.Controllers
{
[ApiController]
[Route("api/currency")]
[EnableCors("AllowOrigin")]
    public class CurrencyController : ControllerBase
{
    private readonly CurrencyConverterService _currencyConverterService;

    public CurrencyController(CurrencyConverterService currencyConverterService)
    {
        _currencyConverterService = currencyConverterService;
    }

    [HttpGet("{year}")]
    public async Task<IActionResult> GetCurrencyData(int year)
    {
        var currencyData = await _currencyConverterService.GetCurrencyDataAsync(year);

        return Ok(currencyData);
    }
}
}
