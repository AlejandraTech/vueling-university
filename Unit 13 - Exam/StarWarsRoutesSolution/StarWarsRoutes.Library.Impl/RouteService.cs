using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Library.Contracts;
using StarWarsRoutes.Library.Contracts.DTOs;

namespace StarWarsRoutes.Library.Impl
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IExternalServicesClient _externalServicesClient;

        public RouteService(IRouteRepository routeRepository, IExternalServicesClient externalServicesClient)
        {
            _routeRepository = routeRepository;
            _externalServicesClient = externalServicesClient;
        }

        public async Task<IEnumerable<RouteDto>> GetRoutesAsync()
        {
            var routes = await _routeRepository.GetAllRoutesAsync();
            return routes.Select(r => new RouteDto
            {
                Origin = r.OriginPlanet.EnglishName,
                Destination = r.DestinationPlanet.EnglishName,
                Distance = r.Distance
            });
        }
    }
}
