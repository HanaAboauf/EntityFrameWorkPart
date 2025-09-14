using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Stud_Course")]
    internal class Stud_CourseDA
    {
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public string Grade { get; set; }
    }
}
