using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models
{
    internal class Aircraft_Routes
    {
        public int Aircraft_RoutesId { get; set; }
        public int Route_Id { get; set; }
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }
    }
}
