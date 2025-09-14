using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Course_Instructor")]
    internal class Course_InstructorDA
    {
        [Key]
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public string Evaluation { get; set; }
    }
}
