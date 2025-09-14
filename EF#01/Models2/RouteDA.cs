using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Route")]
    internal class RouteDA
    {
        [Key]
        public int Id { get; set; }
        public int Distance { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Destination { get; set; }
        public string Origin { get; set; }
        public string Classification { get; set; }
    }
}
