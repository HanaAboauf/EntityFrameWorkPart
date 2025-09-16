using EF_02.DatabaseContexts;
using EF_02.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            Employess employess = new Employess()
            {
                Name = "Hana Hany",
                Position = "Software Engineer",
                Salary = 60000.00m,
                Department = "CS",
                Phone = "01123456789",
                HireDate = DateTime.Now,
                Age = 28,
                Email = "hana@gmail.com"
            };

            #region CRUD Operations

            /* In the change tracker there were states that tell us the state of object with the respect to database
             * state detached ===> the obj doesn't exsit in the db 
             * state add ===> the obj added to db
             * state unchanged ==> the obj exsits in db and doesn't change
             * state modified ===> the obj exsits in db and has been updated
             * State deleted ===> the obj has been deleted from db
             */

            #region Add Employee into database

            //Console.WriteLine("before add employee");

            //var employeeState = dbContext.Entry<Employess>(employess).State;
            //Console.WriteLine($"the state of this employee : {employeeState}"); // detached

            //dbContext.Add(employess);
            //employeeState = dbContext.Add(employess).State;
            //Console.WriteLine($"the state of this employee before saving changes: {employeeState}");

            ////dbContext.Entry<Employess>(employess); // another option to add 
            ////dbContext.Set<Employess>().Add(employess);  // another option to add in case I doesn't create a dbSet in the context
            ////dbContext.Entry(employess).State=EntityState.Added; // another option to add manually
            //dbContext.SaveChanges(); // to save the changes in the db 
            //employeeState = dbContext.Add(employess).State;

            //Console.WriteLine($"the state of this employee after saving changes: {employeeState}");



            #endregion

            #region Retrieve and update employee in db

            //var employee = dbContext.Set<Employess>().FirstOrDefault(e => e.EmpId == 1);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"{employee.Name} - {employee.Email} - {employee.Position}");
            //    Console.WriteLine(dbContext.Entry(employee).State);

            //    employee.Name = "Bishoy";
            //    Console.WriteLine($"{employee.Name} - {employee.Email} - {employee.Position}");
            //    Console.WriteLine(dbContext.Entry(employee).State);
            //    dbContext.SaveChanges();
            //}
            #endregion

            #region Remove employee from db


            //var employee = dbContext.Set<Employess>().FirstOrDefault(e => e.EmpId == 1);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"{employee.Name} - {employee.Email} - {employee.Position}");
            //    Console.WriteLine(dbContext.Entry(employee).State);
            //    dbContext.Set<Employess>().Remove(employee);
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(employee).State);
            //}

            #endregion

            #endregion


        }
    }
}
