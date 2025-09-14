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
    [Table("Instructor")]
    internal class InstructorDA
    {
        [Key]
        public int ins_Id { get; set; }

        [Column("FullName",TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        public string Address { get; set; }
        [Precision(10, 5)]
        public decimal Bouns { get; set; }

        [Precision(10,5)]
        public decimal Salary { get; set; }
        [Precision(10, 5)]
        public decimal Hour_Rate { get; set; }
        public int Dep_Id { get; set; }
    }
}
