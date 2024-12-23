using Microsoft.EntityFrameworkCore;
using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Infrastructure.Contracts.Entities;
using StarWarsRoutes.Infrastructure.Impl.DBContexts;

namespace StarWarsRoutes.Infrastructure.Impl
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly ImperialRoutesContext _context;

        public PlanetRepository(ImperialRoutesContext context)
        {
            _context = context;
        }

        public async Task<Planets> GetPlanetByNameAsync(string name)
        {
            return await _context.Planets
                .FirstOrDefaultAsync(p => p.EnglishName.ToLower() == name.ToLower());
        }

        public async Task<IEnumerable<Planets>> GetAllPlanetsAsync()
        {
            return await _context.Planets.ToListAsync();
        }

        public async Task UpdatePlanetsAsync(IEnumerable<Planets> planets)
        {
            foreach (var planet in planets)
            {
                var existingPlanet = await _context.Planets
                    .FirstOrDefaultAsync(p => p.EnglishName == planet.EnglishName);

                if (existingPlanet == null)
                {
                    planet.CreatedDate = DateTime.UtcNow;
                    _context.Planets.Add(planet);
                }
                else
                {
                    existingPlanet.RebelInfluence = planet.RebelInfluence;
                    existingPlanet.LastUpdateDate = DateTime.UtcNow;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
