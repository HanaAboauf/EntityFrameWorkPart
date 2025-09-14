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
    [Table("Transaction")]
    internal class TransactionDA
    {
        [Key]
        public int TId { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }

        [Precision(10,5)]
        public decimal Amout { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int AL_Id { get; set; }
    }
}
