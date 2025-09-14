using EF_01.Models;
using EF_01.Models2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Contexts
{
    internal class AirlineDbContext : DbContext
    {
        public AirlineDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= AirLine; Trusted_Connection= true; TrustServerCertificate=True");
        }

  

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airline_Phone> Airline_Phones { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Emp_Qualifications> Emp_Qualifications { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Aircraft_Routes> Aircraft_Routes { get; set; }




    }
}
