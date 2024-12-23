using Moq;
using StarWarsRoutes.Infrastructure.Contracts;
using StarWarsRoutes.Infrastructure.Contracts.Entities;
using StarWarsRoutes.Library.Impl;

namespace StarWarsRoutes.Domain.UnitTests
{
    public class RouteServiceTests
    {
        private readonly Mock<IRouteRepository> _routeRepositoryMock;
        private readonly Mock<IExternalServicesClient> _externalServicesClientMock;
        private readonly RouteService _routeService;

        public RouteServiceTests()
        {
            _routeRepositoryMock = new Mock<IRouteRepository>();
            _externalServicesClientMock = new Mock<IExternalServicesClient>();
            _routeService = new RouteService(_routeRepositoryMock.Object, _externalServicesClientMock.Object);
        }

        [Fact]
        public async Task GetRoutesAsync_ShouldReturnMappedRoutes()
        {
            // Arrange
            var routes = new List<Routes>
            {
                new Routes
                {
                    OriginPlanet = new Planets { EnglishName = "Tatooine" },
                    DestinationPlanet = new Planets { EnglishName = "Dagobah" },
                    Distance = 8743
                }
            };

            _routeRepositoryMock.Setup(x => x.GetAllRoutesAsync())
                .ReturnsAsync(routes);

            // Act
            var result = await _routeService.GetRoutesAsync();

            // Assert
            var routeDto = result.First();
            Assert.Equal("Tatooine", routeDto.Origin);
            Assert.Equal("Dagobah", routeDto.Destination);
            Assert.Equal(8743, routeDto.Distance);
        }
    }
}
