using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Aircraft")]
    internal class AircraftDA
    {
        [Key]
        public int Air_Id { get; set; }

        [Required]
        public int Capacity { get; set; }

        [MaxLength(100)]
        public string Model { get; set; }

        [MaxLength(100)]
        public string Maj_pilot { get; set; }
        public string Assistant { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }
        public int AL_Id { get; set; }
    }
}
