using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(Qualifications))]
    internal class EmployeeQualifications
    {
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }

        public string Qualifications { get; set; }

        public Employee Employee { get; set; }
    }
}
