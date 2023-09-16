using System.ComponentModel.DataAnnotations;

namespace BusRouteManagementSystem.Model
{
    public class BusBusStop
    {

        public BusBusStop() { }
        [Key]
        public Guid Id { get; set; }
        public int BusStopNo { get; set; }
        public Guid? BusId { get; set; }
        public Bus Bus { get; set; }
        public Guid? BusStopId { get; set; }
        public BusStop BusStop { get; set; }


        public BusBusStop(string id, int busStopNo, string? busId, string busStopId)
        {
            Id = Guid.Parse(id);
            BusStopNo = busStopNo;
            BusId = Guid.Parse(busId);
            BusStopId =  Guid.Parse(busStopId);
        }

    }
}
