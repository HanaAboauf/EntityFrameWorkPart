using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    internal class Crew
    {
        [Key]
        public int AirCraftId { get; set; }
        public int Id { get; set; }
        public string Maj_Pilot { get; set; }
        public string Assis_Pilot { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }

        public AirCraft AirCraft { get; set; } = null!;



    }
}
