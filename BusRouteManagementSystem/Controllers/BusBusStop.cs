using BusRouteManagementSystem.DataContext;
using BusRouteManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BusRouteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusBusStopController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BusBusStopController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{sourceId}/{destinationId}")]
        public async Task<Response<List<Bus>>> getBusBusStop(Guid sourceId, Guid destinationId)
        {
            var busesPassingThroughSource = await _context.BusBusStops
                    .Where(bbs => bbs.BusStopId == sourceId)
                    .Select(bbs => bbs.BusId)
                    .ToListAsync();

            var busesPassingThroughDestination = await _context.BusBusStops
                .Where(bbs => bbs.BusStopId == destinationId)
                .Select(bbs => bbs.BusId)
                .ToListAsync();

            var busesBetweenSourceAndDestination = await _context.BusBusStops
                    .Where(bbs => busesPassingThroughSource.Contains(bbs.BusId) && busesPassingThroughDestination.Contains(bbs.BusId))
                    .Select(bbs => bbs.Bus)
                    .Distinct()
                    .ToListAsync();


            return new Response<List<Bus>>(busesBetweenSourceAndDestination);
            
        }
    }
}
