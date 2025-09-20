using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.Models
{
    internal class Airline
    {
        [ForeignKey(nameof(Airline))]
        public int employeesId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }

        [InverseProperty(nameof(Employee.Airline))]
        public ICollection<Employee> employees { get; set; }=new HashSet<Employee>();


        [InverseProperty(nameof(Transaction.Airline))]
        public ICollection<Transaction> Transactions { get; set; }=new HashSet<Transaction>();


        public ICollection<AirCraft> AirCrafts { get; set; }=new HashSet<AirCraft>();

        public ICollection<AirlinesPhones> AirlinesPhones { get; set; }=new HashSet<AirlinesPhones>();


    }
}
