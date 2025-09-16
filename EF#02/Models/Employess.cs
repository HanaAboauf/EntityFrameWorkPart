using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Models
{
    internal class Employess
    {

        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime HireDate { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }
    }
}
