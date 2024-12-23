using StarWarsRoutes.Library.Contracts.DTOs;

namespace StarWarsRoutes.Library.Contracts
{
    public interface IPriceCalculatorService
    {
        Task<PriceResponseDto> CalculatePriceAsync(PriceRequestDto request);
    }
}
