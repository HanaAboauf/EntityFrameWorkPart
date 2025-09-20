using EF_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03.ModelsConfigrations
{
    internal class AircraftRouteConfig: IEntityTypeConfiguration<AircraftRoute>
    {
        public void Configure(EntityTypeBuilder<AircraftRoute> builder)
        {
            // from aircraft side
            builder.HasOne(ar => ar.AirCraft)
                   .WithMany(r=>r.AircraftRoutes)
                   .HasForeignKey(ar => ar.AirCraftId);

            // from route side
            builder.HasOne(ar => ar.Route)
                   .WithMany(ac => ac.AircraftRoutes)
                   .HasForeignKey(ar => ar.RouteId);


            builder.Property<TimeSpan>("Duration");

        }

   
    }

}
