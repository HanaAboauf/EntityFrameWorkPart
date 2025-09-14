using EF_01.Models2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Contexts
{
    internal class ITIDaDbContext : DbContext
    {
        public ITIDaDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= ITI_DbV2; Trusted_Connection= true; TrustServerCertificate=True");
        }


        public DbSet<StudentDA> students { get; set; }

        public DbSet<DepartmentDA> departments { get; set; }

        public DbSet<InstructorDA> instructors { get; set; }

        public DbSet<CourseDA> courses { get; set; }

        public DbSet<TopicDA> topics { get; set; }

        public DbSet<Stud_CourseDA> Stud_Courses { get; set; }

        public DbSet<Course_InstructorDA> Course_Instructors { get; set; }



    }
}
