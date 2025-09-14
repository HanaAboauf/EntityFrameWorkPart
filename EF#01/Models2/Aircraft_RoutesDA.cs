using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Aircraft_Routes")]
    internal class Aircraft_RoutesDA
    {
        [Key]
        public int AC_Id { get; set; }
        public int Route_Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }

        [Precision(10,5)]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Arrival { get; set; }
    }
}
