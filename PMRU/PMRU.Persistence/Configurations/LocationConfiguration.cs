using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.LocationID);
            builder.Property(l => l.LocationDescription).HasMaxLength(255).IsRequired();
            builder.Property(l => l.IsLocationCenter).IsRequired();


            builder.HasData(
                new Location { LocationID = 34, LocationDescription = "Genel Müdürlük", IsLocationCenter = true },
                new Location { LocationID = 35, LocationDescription = "İzmir", IsLocationCenter = false },
                new Location { LocationID = 41, LocationDescription = "İzmit", IsLocationCenter = false },
                new Location { LocationID = 72, LocationDescription = "Batman", IsLocationCenter = false },
                new Location { LocationID = 71, LocationDescription = "Kırıkkale", IsLocationCenter = false }

            );
        }
    }
}
