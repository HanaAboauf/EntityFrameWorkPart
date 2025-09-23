using EF_03.DatabaseContexts;

using EF_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirlineDbContext dbcontext = new AirlineDbContext();

            #region Assignment03
            #region Question A


            //dbcontext.Airlines.Add(new Airline
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Address = "Cairo",
            //    AirlinesPhones = new List<AirlinesPhones>
            //    {
            //        new AirlinesPhones { phones = "0123456789" },
            //        new AirlinesPhones { phones = "0113654789" }
            //    }
            //});

            //dbcontext.SaveChanges();




            #endregion

            #region Question B

            //var AirlineId = dbcontext.Airlines?.FirstOrDefault(a => a.Name == "EgyptAir").Id;

            //if (AirlineId != null)
            //{
            //    dbcontext.AirCrafts.Add(new AirCraft
            //    {
            //        Model = "Model01",
            //        Capacity = 180,
            //        AirlineId = (int)AirlineId
            //    });
            //    dbcontext.SaveChanges();
            //}

            #endregion

            #region Question C

            //var AirlineId = dbcontext.Airlines?.FirstOrDefault(a => a.Name == "EgyptAir").Id;
            //if (AirlineId != null)
            //{
            //    dbcontext.Transactions.Add(new Transaction
            //    {
            //        AirlineId = (int)AirlineId,
            //        Amount = 50000,
            //        Date = DateTime.Now,
            //        Description = "Tickets"
            //    });
            //    dbcontext.SaveChanges();
            //}
            #endregion

            #region Question D

            //var employees = dbcontext.Airlines
            //  .Where(a => a.Name == "EgyptAir")
            //  .Select(a => a.ContactPerson)
            //  .ToList();
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region Question E

            //var transactions = dbcontext.Transactions.Where(t => t.Airline.Name == "EgyptAir")
            //    .Select(t => new { t.Id, t.Description, t.Amount })
            //    .ToList();
            //foreach (var transaction in transactions)
            //{
            //    Console.WriteLine($"ID: {transaction.Id}, Description: {transaction.Description}, Amount: {transaction.Amount}");
            //}
            #endregion

            #region Question F

            //var employeeCounts = dbcontext.Airlines.GroupBy(a => a.Name)
            //    .Select(g => new { AirlineName = g.Key, EmployeeCount = g.Select(a => a.ContactPerson).Count() })
            //    .ToList();
            //foreach (var item in employeeCounts)
            //{
            //    Console.WriteLine($"Airline: {item.AirlineName}, Employee Count: {item.EmployeeCount}");
            //}
            #endregion

            #region Question G

            //var aircraft = dbcontext.AirCrafts.Where(ac => ac.Model == "Model01");

            //if (aircraft != null)
            //{
            //    foreach (var ac in aircraft)
            //    {
            //        ac.Capacity = 200;
            //    }
            //    dbcontext.SaveChanges();
            //}

            #endregion

            #region Question H

            //var oldTransactions = dbcontext.Transactions.Where(t => t.Date < new DateTime(2020, 1, 1)).ToList();
            //if (oldTransactions.Any())
            //{
            //    dbcontext.Transactions.RemoveRange(oldTransactions);
            //    dbcontext.SaveChanges();
            //}

            #endregion

            #region Question I

            //dbcontext.Routes.Add(new Route()
            //{
            //    Origin = "Cairo",
            //    Destination = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //});
            //dbcontext.SaveChanges();

            #endregion

            #region Question J

            //var route = dbcontext.Routes
            //    .FirstOrDefault(r => r.Origin == "Cairo" && r.Destination == "Dubai");

            //var aircraft = dbcontext.AirCrafts
            //    .FirstOrDefault(ac => ac.Model == "Model01");

            //if (route != null && aircraft != null)
            //{
            //    var aircraftRoute = new AircraftRoute
            //    {
            //        AirCraftId = aircraft.Id,
            //        RouteId = route.Id,
            //        Price = 3000
            //    };

            //    dbcontext.Set<AircraftRoute>().Add(aircraftRoute);
            //    dbcontext.SaveChanges();

            //    dbcontext.Entry(aircraftRoute).Property("Duration").CurrentValue = TimeSpan.FromHours(4);

            //    dbcontext.SaveChanges();
            //}

            #endregion
            #endregion

            #region Assignment04

            #region Section A

            #region Question01


            //var airlineWithAircraftsAndRoutes = dbcontext.Airlines.Include(a => a.AirCrafts)
            //    .ThenInclude(ac => ac.AircraftRoutes)
            //    .ThenInclude(ar => ar.Route)
            //    .FirstOrDefault(a => a.Name == "EgyptAir");

            //if (airlineWithAircraftsAndRoutes is not null)
            //{
            //    Console.WriteLine("The aircrafts of EgyptAir are");
            //    foreach (var aircraft in airlineWithAircraftsAndRoutes.AirCrafts)
            //    {
            //        Console.WriteLine($"Aircraft Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
            //        Console.WriteLine("Routes:");
            //        foreach (var aircraftRoute in aircraft.AircraftRoutes)
            //        {
            //            var route = aircraftRoute.Route;
            //            Console.WriteLine($" - From {route.Origin} to {route.Destination}, Distance: {route.Distance} km, Classification: {route.Classification}");
            //        }
            //    }
            //}
            #endregion

                #endregion

                #endregion
        }
    }
}
