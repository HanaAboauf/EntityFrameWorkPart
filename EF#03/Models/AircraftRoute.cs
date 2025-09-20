using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    [PrimaryKey(nameof(AirCraftId), nameof(RouteId))]
    internal class AircraftRoute
    {
        public int AirCraftId { get; set; }

        public int RouteId { get; set; }

        public decimal Price { get; set; }

        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public Route? Route { get; set; }

        public AirCraft? AirCraft { get; set; }

    }
}
