using System.ComponentModel.DataAnnotations;

namespace BusRouteManagementSystem.Model
{
    public class BusStop
    {
        [Key]
        public Guid Id { get; set; }

        public string Busstop_Name { get; set; }

        public List<Bus>Buses { get; set; }

        public BusStop() { }

        public BusStop(string id, string busstopName)
        {
            Id = Guid.Parse(id);
            Busstop_Name = busstopName;
        }



    }
}
