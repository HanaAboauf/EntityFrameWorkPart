using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public int BD_Year { get; set; }
        public int BD_Month { get; set; }
        public int BD_Day { get; set; }
        public int AL_Id { get; set; }
    }
}
