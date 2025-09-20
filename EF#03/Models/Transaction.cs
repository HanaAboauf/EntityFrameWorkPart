using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    internal class Transaction
    {
        public int AirlineId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }


        public Airline Airline { get; set; } = null!;
    }
}
