using BusRouteManagementSystem.DataContext;
using BusRouteManagementSystem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusRouteManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BusDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public async Task<Response<List<BusBusStop>>> getBusBusStop(Guid Id)
        {
              var busStops = await _context.BusBusStops.Where(bbs => bbs.BusId == Id).Include(bbs => bbs.BusStop).OrderBy(bbs => bbs.BusStopNo).ToListAsync();

            return new Response<List<BusBusStop>>(busStops);

        }
    }
}
