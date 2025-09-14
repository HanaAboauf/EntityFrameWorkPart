using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Airline_Phones")]
    internal class Airline_PhonesDA
    {
        [Key]
        public int AL_Id { get; set; }
        [Required]
        [MaxLength(11)]
        public string Phones { get; set; }
    }
}
