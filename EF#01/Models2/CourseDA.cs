using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Course")]
    internal class CourseDA
    {
        [Key]
        public int CId { get; set; }

        [Column("FullName",TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int top_Id { get; set; }
    }
}
