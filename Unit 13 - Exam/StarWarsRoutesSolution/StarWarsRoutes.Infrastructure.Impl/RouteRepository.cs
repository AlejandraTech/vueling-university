using Microsoft.EntityFrameworkCore;
using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Infrastructure.Contracts.Entities;
using StarWarsRoutes.Infrastructure.Impl.DBContexts;

namespace StarWarsRoutes.Infrastructure.Impl
{
    public class RouteRepository : IRouteRepository
    {
        private readonly ImperialRoutesContext _context;

        public RouteRepository(ImperialRoutesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Routes>> GetAllRoutesAsync()
        {
            return await _context.Routes
                .Include(r => r.OriginPlanet)
                .Include(r => r.DestinationPlanet)
                .ToListAsync();
        }

        public async Task<Routes> GetRouteByPlanetsAsync(string origin, string destination)
        {
            return await _context.Routes
                .Include(r => r.OriginPlanet)
                .Include(r => r.DestinationPlanet)
                .FirstOrDefaultAsync(r =>
                    r.OriginPlanet.EnglishName.ToLower() == origin.ToLower() &&
                    r.DestinationPlanet.EnglishName.ToLower() == destination.ToLower());
        }

        public async Task UpdateRoutesAsync(IEnumerable<Routes> routes)
        {
            foreach (var route in routes)
            {
                var existingRoute = await _context.Routes
                    .FirstOrDefaultAsync(r =>
                        r.OriginPlanetId == route.OriginPlanetId &&
                        r.DestinationPlanetId == route.DestinationPlanetId);

                if (existingRoute == null)
                {
                    route.CreatedDate = DateTime.UtcNow;
                    _context.Routes.Add(route);
                }
                else
                {
                    existingRoute.Distance = route.Distance;
                    existingRoute.LastUpdateDate = DateTime.UtcNow;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
