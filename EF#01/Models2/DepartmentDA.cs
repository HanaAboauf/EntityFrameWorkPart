using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Department")]
    internal class DepartmentDA
    {
        [Key]
        public int DId { get; set; }

        [Column("FullName", TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Hiring_Date { get; set; }
        public int Ins_Id { get; set; }
    }
}
