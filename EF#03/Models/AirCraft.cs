using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    internal class AirCraft
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }

        public int AirlineId { get; set; }

        public Airline Airline { get; set; } = null!;
        
        public Crew Crew { get; set; } = null!; 

        public ICollection<AircraftRoute> AircraftRoutes { get; set; } = new HashSet<AircraftRoute>();
    }
}
