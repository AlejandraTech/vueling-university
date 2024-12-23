using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Library.Contracts;
using StarWarsRoutes.Library.Contracts.DTOs;

namespace StarWarsRoutes.Library.Impl
{
    public class PriceCalculatorService : IPriceCalculatorService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IPlanetRepository _planetRepository;
        private readonly IExternalServicesClient _externalServicesClient;
        private const decimal ELITE_DEFENSE_THRESHOLD = 40m;

        public PriceCalculatorService(
            IRouteRepository routeRepository,
            IPlanetRepository planetRepository,
            IExternalServicesClient externalServicesClient)
        {
            _routeRepository = routeRepository;
            _planetRepository = planetRepository;
            _externalServicesClient = externalServicesClient;
        }

        public async Task<PriceResponseDto> CalculatePriceAsync(PriceRequestDto request)
        {
            var route = await _routeRepository.GetRouteByPlanetsAsync(request.Origin, request.Destination);
            if (route == null)
                throw new KeyNotFoundException("Route not found");

            var currentPrice = await _externalServicesClient.GetCurrentPriceAsync();
            var basePrice = route.Distance * currentPrice.PricePerLunarDay;

            var originPlanet = await _planetRepository.GetPlanetByNameAsync(request.Origin);
            var destPlanet = await _planetRepository.GetPlanetByNameAsync(request.Destination);

            var totalRebelInfluence = originPlanet.RebelInfluence + destPlanet.RebelInfluence;
            var eliteDefenseCost = totalRebelInfluence > ELITE_DEFENSE_THRESHOLD
                ? (totalRebelInfluence - ELITE_DEFENSE_THRESHOLD) / 100m * basePrice
                : 0;

            var originDefenseCost = (originPlanet.RebelInfluence / 100m) * basePrice;
            var destDefenseCost = (destPlanet.RebelInfluence / 100m) * basePrice;

            return new PriceResponseDto
            {
                TotalAmount = Math.Round(basePrice + originDefenseCost + destDefenseCost + eliteDefenseCost, 2),
                PricesPerLunarDay = Math.Round(currentPrice.PricePerLunarDay, 2),
                Taxes = new TaxesDto
                {
                    OriginDefenseCost = Math.Round(originDefenseCost, 2),
                    DestinationDefenseCost = Math.Round(destDefenseCost, 2),
                    EliteDefenseCost = Math.Round(eliteDefenseCost, 2)
                }
            };
        }
    }
}
