using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Airline")]
    internal class AirlineDA
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="the name must be at most 50 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cont_person { get; set; }
    }
}
