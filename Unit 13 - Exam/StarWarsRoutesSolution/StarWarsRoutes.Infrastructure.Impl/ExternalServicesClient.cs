using Microsoft.Extensions.Configuration;
using StarWarsRoutes.Domain.Models;
using StarWarsRoutes.Infrastructure.Contracts;
using System.Text.Json;

namespace StarWarsRoutes.Infrastructure.Impl
{
    public class ExternalServicesClient : IExternalServicesClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ExternalServicesClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Price> GetCurrentPriceAsync()
        {
            var response = await _httpClient.GetStringAsync(_configuration["ExternalApis:EmpirePrices"]);
            return JsonSerializer.Deserialize<Price>(response);
        }

        public async Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            var response = await _httpClient.GetStringAsync(_configuration["ExternalApis:SindicatePlanets"]);
            return JsonSerializer.Deserialize<IEnumerable<Planet>>(response);
        }

        public async Task<IEnumerable<Route>> GetRoutesAsync()
        {
            var response = await _httpClient.GetStringAsync(_configuration["ExternalApis:SindicateDistances"]);
            return JsonSerializer.Deserialize<IEnumerable<Route>>(response);
        }

        public async Task<IEnumerable<SpyReport>> GetSpyReportAsync()
        {
            var response = await _httpClient.GetStringAsync(_configuration["ExternalApis:EmpireSpyReport"]);
            return JsonSerializer.Deserialize<IEnumerable<SpyReport>>(response);
        }
    }
}
