using EF_03.ModelsInheritance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.DatabaseContexts
{
    internal class TransportationDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= Mapping_DB; Trusted_Connection= true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Vehicle>()
                .HasDiscriminator<string>("VehicleType")
                .HasValue<Car>("Car")
                .HasValue<Bus>("Bus");

            modelBuilder.Entity<CashPayment>()
                .ToTable("CashPayment");

            modelBuilder.
                Entity<CreditCardPayment>()
                .ToTable("CreditCardPayment");
        }

        #region Inheritance part (TPH)

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Bus> Buses { get; set; }
        #endregion

        #region (TPT)

        public DbSet<Payment> Payments { get; set; }
        public DbSet<CashPayment> CashPayments { get; set; }

        public DbSet<CreditCardPayment> CreditCardPayments { get; set; }
        #endregion

        #region (TPC)

        public DbSet<Electronics> Electronics { get; set; }

        public DbSet<Book> Books { get; set; }
        #endregion


    }
}
