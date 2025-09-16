using EF_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.DatabaseContexts
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= CompanyDB; Trusted_Connection= true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employess>().ToTable("EmployeeTable");
            modelBuilder.Entity<Employess>().HasKey(E => E.EmpId);
            modelBuilder.Entity<Employess>().Property(e => e.Name).HasColumnName("EmployeeName").
                HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Employess>().Property(e => e.Position)
                .HasMaxLength(50);
            modelBuilder.Entity<Employess>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)"); // also I can use HasPrecision(18,2)
            modelBuilder.Entity<Employess>()
                .ToTable(t=>t.HasCheckConstraint("validate Email", "[Email] like '%@%.%'"));
            modelBuilder.Entity<Employess>()
                .ToTable(t => t.HasCheckConstraint("validate Salary", "[Salary] > 0"));
            modelBuilder.Entity<Employess>().ToTable(t => t.HasCheckConstraint("validate Age", "[Age] >= 18 and [Age]<=30"));
            modelBuilder.Entity<Employess>().Property(e => e.Department).HasMaxLength(50);
            modelBuilder.Entity<Employess>().Property(e => e.Phone).HasMaxLength(11);
            modelBuilder.Entity<Employess>().Property(e => e.HireDate)
                .HasAnnotation("DataType", "DateTime")
                .HasDefaultValueSql("getdate()");// this method to set the time when the record is created
              //.HasComputedColumnSql("getdate()");// this method to set the time when the record is created and updated

        }
    }
}
