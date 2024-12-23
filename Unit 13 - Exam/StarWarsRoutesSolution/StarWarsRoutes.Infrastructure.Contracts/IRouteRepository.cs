using StarWarsRoutes.Infrastructure.Contracts.Entities;

namespace StarWarsRoutes.Infrastructure.Contracts
{
    public interface IRouteRepository
    {
        Task<IEnumerable<Routes>> GetAllRoutesAsync();
        Task<Routes> GetRouteByPlanetsAsync(string origin, string destination);
        Task UpdateRoutesAsync(IEnumerable<Routes> routes);
    }
}
