using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models2
{
    [Table("Topic")]
    internal class TopicDA
    {

        [Key]
        public int TId { get; set; }

        [Column("FullName")]
        public string Name { get; set; }
    }
}
