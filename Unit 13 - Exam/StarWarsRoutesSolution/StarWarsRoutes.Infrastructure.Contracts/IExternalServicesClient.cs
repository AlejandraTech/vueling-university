using StarWarsRoutes.Domain.Models;

namespace StarWarsRoutes.Infrastructure.Contracts
{
    public interface IExternalServicesClient
    {
        Task<Price> GetCurrentPriceAsync();
        Task<IEnumerable<Planet>> GetPlanetsAsync();
        Task<IEnumerable<Route>> GetRoutesAsync();
        Task<IEnumerable<SpyReport>> GetSpyReportAsync();
    }
}
