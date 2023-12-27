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
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(p => p.PositionID);
            builder.Property(p => p.PositionDescription).HasMaxLength(255).IsRequired();

            builder.HasData(
                new Position { PositionID = 1, PositionDescription = "Güvenlik Şefi" },
                new Position { PositionID = 2, PositionDescription = "Güvenlik Görevlisi" },
                new Position { PositionID = 3, PositionDescription = "Elektrik Mühendisi" },
                new Position { PositionID = 4, PositionDescription = "Makine Mühendisi" },
                new Position { PositionID = 5, PositionDescription = "Muhasebe Uzmanı" },
                new Position { PositionID = 6, PositionDescription = "Personel Uzmanı" },
                new Position { PositionID = 7, PositionDescription = "İnsan Kaynakları Uzmanı" },
                new Position { PositionID = 8, PositionDescription = "Yazılım Geliştirici" },
                new Position { PositionID = 9, PositionDescription = "Test Uzmanı" },
                new Position { PositionID = 10, PositionDescription = "Finans Uzmanı" },
                new Position { PositionID = 11, PositionDescription = "Pazarlama Uzmanı" },
                new Position { PositionID = 12, PositionDescription = "Doktor" },
                new Position { PositionID = 13, PositionDescription = "Hemşire" },
                new Position { PositionID = 14, PositionDescription = "Satış Temsilcisi" }

            );
        }
    }
}
