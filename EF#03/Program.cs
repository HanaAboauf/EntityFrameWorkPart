using EF_03.DatabaseContexts;

using EF_03.Models;

namespace EF_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirlineDbContext dbcontext = new AirlineDbContext();

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
           
            var AirlineId = dbcontext.Airlines?.FirstOrDefault(a => a.Name == "EgyptAir").Id;

            if (AirlineId != null)
            {
                dbcontext.AirCrafts.Add(new AirCraft
                {
                    Model = "Model01",
                    Capacity = 180,
                    AirlineId = (int)AirlineId
                });
                dbcontext.SaveChanges();
            }

            #endregion
        }
    }
}
