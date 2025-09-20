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
    internal class AirCraftConfig : IEntityTypeConfiguration<AirCraft>
    {
        public void Configure(EntityTypeBuilder<AirCraft> builder)
        {
            builder.HasOne(ac=>ac.Crew)
                 .WithOne(c=>c.AirCraft)
                 .HasForeignKey<Crew>(c=>c.AirCraftId);
        }
    }
}
