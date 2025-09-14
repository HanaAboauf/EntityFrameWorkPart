using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Emp_Qualifications")]
    internal class Emp_QualificationsDA
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required]
        public string Qualifications { get; set; }
    }
}
