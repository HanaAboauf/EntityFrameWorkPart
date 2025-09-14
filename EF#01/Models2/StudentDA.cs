using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{

    [Table("Student")]
    internal class StudentDA
    {
        [Key]
        public int SId { get; set; }

        [Required]
        [MaxLength(20)]
        public string FName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LName { get; set; }

        [Range(18,30)]
        public int Age { get; set; }
        public string Address { get; set; }
        public int Dep_Id { get; set; }
    }
}
