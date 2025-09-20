using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    [PrimaryKey(nameof(AirlineId), nameof(phones))]
    internal class AirlinesPhones
    {
        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }

        public string phones { get; set; }

        public Airline Airline { get; set; }
    }
}
