using EF_01.Models2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Contexts
{
    internal class AirlineDADbContext: DbContext
    {
        public AirlineDADbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= AirLineV2; Trusted_Connection= true; TrustServerCertificate=True");
        }

        public DbSet<AircraftDA> aircraftDAs { get; set; }

        public DbSet<Aircraft_RoutesDA> routesDAs { get; set; }

        public DbSet<AirlineDA> airlineDAs { get; set; }

        public DbSet<Airline_PhonesDA> airline_PhonesDAs { get; set; }

        public DbSet<EmployeeDA> employeesDAs { get; set; }

        public DbSet<Emp_QualificationsDA> emp_QualificationsDAs { get; set;}

        public DbSet<RouteDA> routeDAs { get; set; }

        public DbSet<TransactionDA> transactionDAs { get; set; }    

    }
}
