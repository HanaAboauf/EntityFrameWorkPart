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
    internal class AirlineConfig : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasMany(a => a.AirCrafts)
                   .WithOne(ac => ac.Airline)
                   .HasForeignKey(ac => ac.AirlineId);

            builder.HasMany(a=>a.AirlinesPhones)
                   .WithOne(ap=>ap.Airline)
                   .HasForeignKey(ap=>ap.AirlineId);
        }
    }
}
