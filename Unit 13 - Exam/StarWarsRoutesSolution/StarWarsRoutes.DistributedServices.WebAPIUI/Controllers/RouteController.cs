using Microsoft.AspNetCore.Mvc;
using StarWarsRoutes.Library.Contracts.DTOs;
using StarWarsRoutes.Library.Contracts;

namespace StarWarsRoutes.DistributedServices.WebAPIUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;

        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RouteDto>>> GetRoutes()
        {
            try
            {
                var routes = await _routeService.GetRoutesAsync();
                return Ok(routes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
