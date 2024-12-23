using StarWarsRoutes.Library.Contracts.DTOs;

namespace StarWarsRoutes.Library.Contracts
{
    public interface IRouteService
    {
        Task<IEnumerable<RouteDto>> GetRoutesAsync();
    }
}
