using EF_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.ModelConfigrations
{
    internal class EmployeeConfigrations : IEntityTypeConfiguration<Employess>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employess> builder)
        {
            builder.ToTable("EmployeeTable");
            builder.HasKey(E => E.EmpId);

            builder.Property(e=>e.EmpId).UseIdentityColumn(10,10);
            builder.Property(e => e.Name).HasColumnName("EmployeeName").
                HasMaxLength(50).IsRequired();
            builder.Property(e => e.Position)
                .HasMaxLength(50);
            builder
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)"); // also I can use HasPrecision(18,2)
            builder
                 .ToTable(t => t.HasCheckConstraint("validate Email", "[Email] like '%@%.%'"));
            builder
                .ToTable(t => t.HasCheckConstraint("validate Salary", "[Salary] > 0"));
            builder.ToTable(t => t.HasCheckConstraint("validate Age", "[Age] >= 18 and [Age]<=30"));
            builder.Property(e => e.Department).HasMaxLength(50);
            builder.Property(e => e.Phone).HasMaxLength(11);
            builder.Property(e => e.HireDate)
                .HasAnnotation("DataType", "DateTime")
                .HasDefaultValueSql("getdate()");// this method to set the time when the record is created
                                                 //.HasComputedColumnSql("getdate()");// this method to set the time when the record is created and updated
        }
    }
}
