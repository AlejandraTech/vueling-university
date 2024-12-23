using StarWarsRoutes.Infrastructure.Contracts.Entities;

namespace StarWarsRoutes.Infrastructure.Contracts
{
    public interface IPlanetRepository
    {
        Task<Planets> GetPlanetByNameAsync(string name);
        Task<IEnumerable<Planets>> GetAllPlanetsAsync();
        Task UpdatePlanetsAsync(IEnumerable<Planets> planets);
    }
}
