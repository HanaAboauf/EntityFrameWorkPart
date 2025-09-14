using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amout { get; set; }
        public DateTime Date { get; set; }
        public int AL_Id { get; set; }
    }
}
