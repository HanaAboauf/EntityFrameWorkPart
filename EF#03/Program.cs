using EF_03.DatabaseContexts;

using EF_03.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

            #region Question02

            //var airlinesWithEmployeesAndQualifications = dbcontext.Airlines
            //    .Include(a => a.employees)
            //    .ThenInclude(e => e.EmployeeQualifications)
            //    .GroupBy(a => a.Name)
            //    .ToList();

            //if(airlinesWithEmployeesAndQualifications is not null)
            //{
            //    foreach (var airlineGroup in airlinesWithEmployeesAndQualifications)
            //    {
            //        Console.WriteLine($"Airline: {airlineGroup.Key}");
            //        foreach (var employee in airlineGroup.SelectMany(a => a.employees))
            //        {
            //            Console.WriteLine($" Employee: {employee.Name}, Position: {employee.Position}");
            //            foreach (var qualification in employee.EmployeeQualifications)
            //            {
            //                Console.WriteLine($"  - Qualification: {qualification.Qualifications}");
            //            }
            //        }
            //    }

            //}

            #endregion

            #region Question03

            //var airlinesWithHighValueTransactions = dbcontext.Airlines
            //    .Include(a => a.Transactions.Where(t => t.Amount > 10000))
            //    .ToList();

            //if (airlinesWithHighValueTransactions is not null)
            //{
            //    foreach (var airline in airlinesWithHighValueTransactions)
            //    {
            //        Console.WriteLine($"Airline: {airline.Name}");
            //        foreach (var transaction in airline.Transactions)
            //        {
            //            Console.WriteLine($" Transaction ID: {transaction.Id}, Amount: {transaction.Amount}, Date: {transaction.Date}, Description: {transaction.Description}");
            //        }
            //    }
            //}
            #endregion

            #region Question04

            //var routesWithAircraftModels = dbcontext.Routes.Include(r => r.AircraftRoutes)
            //    .ThenInclude(ar => ar.AirCraft)
            //    .ToList();

            //if (routesWithAircraftModels is not null)
            //{
            //    foreach (var route in routesWithAircraftModels)
            //    {
            //        Console.WriteLine($"Route from {route.Origin} to {route.Destination}, Distance: {route.Distance} km, Classification: {route.Classification}");
            //        Console.WriteLine("Assigned Aircrafts:");
            //        foreach (var aircraftRoute in route.AircraftRoutes)
            //        {
            //            var aircraft = aircraftRoute.AirCraft;
            //            Console.WriteLine($" - Aircraft Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
            //        }
            //    }
            //}
            #endregion

            #region Question05

            //var aircraftsWithAirlineAndPhones = dbcontext.AirCrafts.Include(ac => ac.Airline)
            //    .ThenInclude(a => a.AirlinesPhones)
            //    .ToList();

            //if (aircraftsWithAirlineAndPhones is not null)
            //{
            //    foreach (var aircraft in aircraftsWithAirlineAndPhones)
            //    {
            //        Console.WriteLine($"Aircraft Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
            //        Console.WriteLine($"Airline: {aircraft.Airline.Name}");
            //        Console.WriteLine("Airline Phones:");
            //        foreach (var phone in aircraft.Airline.AirlinesPhones)
            //        {
            //            Console.WriteLine($" - Phone: {phone.phones}");
            //        }
            //    }
            //}
            #endregion

            #endregion

            #region Section B

            #region Question01

            //var employeesWithAirline = dbcontext.Employees.GroupJoin(dbcontext.Airlines,
            //    emp => emp.Id,
            //    air => air.employeesId,
            //    (emp, air) => new
            //    {
            //        Employee = emp,
            //        Airline = air
            //    })
            //    .SelectMany(ea => ea.Airline.DefaultIfEmpty(), (ea, air) => new
            //    {
            //        Name = ea.Employee.Name,
            //        Position = ea.Employee.Position,
            //        AirlineName = air != null ? air.Name : "No Airline"
            //    })
            //    .GroupBy(e => e.AirlineName)
            //    .ToList();
            //if (employeesWithAirline is not null)
            //{
            //    foreach (var airlineGroup in employeesWithAirline)
            //    {
            //        Console.WriteLine($"Airline: {airlineGroup.Key}");
            //        foreach (var employee in airlineGroup)
            //        {
            //            Console.WriteLine($" - Employee: {employee.Name}, Position: {employee.Position}");
            //        }
            //    }
            //}

            #endregion

            #region Question02

            var routesWithAircraftAndAirline = dbcontext.Routes.GroupJoin(dbcontext.AircraftRoutes, r => r.Id, ar => ar.RouteId, (r,ar)=>new
            {
                Route = r,
                AircraftRoutes = ar
            }).SelectMany(
                ra => ra.AircraftRoutes.DefaultIfEmpty(),
                (r, ar) => new
            {
              RouteId = r.Route.Id,
             Origin = r.Route.Origin,
             Destination = r.Route.Destination,
             AircarftModel=ar != null ? ar.AirCraft.Model : "No Aircraft Assigned",
             AirlineName= ar != null ? ar.AirCraft.Airline.Name : "No Airline"

                });
            #endregion

            #region Question03

            var airlinesWithAircraftModels = dbcontext.Airlines.GroupJoin(dbcontext.AirCrafts,a=>a.Id,ac=>ac.AirlineId,(a,ac)=>new
            {
                Airline=a,
                AirCrafts=ac
            }).SelectMany(
                aa=>aa.AirCrafts.DefaultIfEmpty(),
                (a,ac)=>new
                {
                    AirlineName=a.Airline.Name,
                    AircraftModel=ac != null ? ac.Model : "No Aircraft"
                });
            if (airlinesWithAircraftModels is not null)
            {
                foreach (var item in airlinesWithAircraftModels)
                {
                    Console.WriteLine($"Airline: {item.AirlineName}, Aircraft Model: {item.AircraftModel}");
                }
            }
            #endregion

            #region Question04
            var transactionsWithAir=dbcontext.Transactions.GroupJoin(dbcontext.Airlines,t=>t.AirlineId,a=>a.Id,(t,a)=>new
            {
                Transaction=t,
                Airline=a
            }).SelectMany(
                ta=>ta.Airline.DefaultIfEmpty(),
                (t,a)=>new
                {
                    TransactionId=t.Transaction.Id,
                    Amount=t.Transaction.Amount,
                    Description=t.Transaction.Description,
                    AirlineName=a != null ? a.Name : "No Airline"
                }).Where(t=>t.Amount>20000);
            if (transactionsWithAir is not null)
            {
                foreach (var item in transactionsWithAir)
                {
                    Console.WriteLine($"Transaction ID: {item.TransactionId}, Amount: {item.Amount}, Description: {item.Description}, Airline: {item.AirlineName}");
                }
            }
            #endregion

                #endregion



                #endregion
        }
    }
}
