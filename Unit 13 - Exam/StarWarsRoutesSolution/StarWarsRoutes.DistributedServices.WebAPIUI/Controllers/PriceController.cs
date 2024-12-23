using Microsoft.AspNetCore.Mvc;
using StarWarsRoutes.Library.Contracts;
using StarWarsRoutes.Library.Contracts.DTOs;

namespace StarWarsRoutes.DistributedServices.WebAPIUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly IPriceCalculatorService _priceCalculatorService;

        public PriceController(IPriceCalculatorService priceCalculatorService)
        {
            _priceCalculatorService = priceCalculatorService;
        }

        [HttpPost("calculate")]
        public async Task<ActionResult<PriceResponseDto>> CalculatePrice(PriceRequestDto request)
        {
            try
            {
                var price = await _priceCalculatorService.CalculatePriceAsync(request);
                return Ok(price);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
