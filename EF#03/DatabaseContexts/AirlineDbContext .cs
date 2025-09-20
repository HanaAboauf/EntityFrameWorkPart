using EF_03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.DatabaseContexts
{
    internal class AirlineDbContext : DbContext
    {
        public AirlineDbContext(): base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= AirLine_DB; Trusted_Connection= true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<AirCraft> AirCrafts { get; set; }

        public DbSet<Crew> Crews { get; set; }

        public DbSet<Route> Routes { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Transaction> Transactions { get; set; }


    }
}
