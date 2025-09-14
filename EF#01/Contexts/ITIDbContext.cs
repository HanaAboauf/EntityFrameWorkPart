using EF_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Contexts
{
    internal class ITIDbContext:DbContext
    {
        public ITIDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= ITI_Db; Trusted_Connection= true; TrustServerCertificate=True");
        }

        public DbSet<Student>students { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<Instructor> instructors { get; set; }

        public DbSet<Course> courses { get; set; }

        public DbSet<Topic> topics { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set; }

        public DbSet<Course_Instructor> Course_Instructors { get; set; }





    }
}
