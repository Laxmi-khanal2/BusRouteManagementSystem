using System.ComponentModel.DataAnnotations;

namespace BusRouteManagementSystem.Model
{
    public class Bus
    {
        [Key]
        public Guid Id { get; set; }
        public string BusNumber { get; set; }
        public string? BusName { get; set; }

        public List<BusStop>? Stops { get; set; }
        
       public Bus()
        {

        }
        public Bus(string id, string busNumber, string? busName)
        {
            Id = Guid.Parse(id);
            BusNumber = busNumber;
            BusName = busName;
        }


    }
}
