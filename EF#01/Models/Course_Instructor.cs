using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models
{
    internal class Course_Instructor
    {
        public int Course_InstructorId { get; set; }
        public int Inst_Id { get; set; }
        public string Evaluation { get; set; }
    }
}
