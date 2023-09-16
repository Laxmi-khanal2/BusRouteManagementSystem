using BusRouteManagementSystem.DataContext;
using BusRouteManagementSystem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusRouteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusStopController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BusStopController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<Response<List<BusStop>>> getBusStop()
        {
            var busStop =   _context.BusStop.ToList();

            return new Response<List<BusStop>>(busStop);
        }


    }
}
