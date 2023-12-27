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
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PositionDescription).HasMaxLength(255).IsRequired();

            builder.HasData(
                new Position { Id = 1, PositionDescription = "Güvenlik Şefi" },
                new Position { Id = 2, PositionDescription = "Güvenlik Görevlisi" },
                new Position { Id = 3, PositionDescription = "Elektrik Mühendisi" },
                new Position { Id = 4, PositionDescription = "Makine Mühendisi" },
                new Position { Id = 5, PositionDescription = "Muhasebe Uzmanı" },
                new Position { Id = 6, PositionDescription = "Personel Uzmanı" },
                new Position { Id = 7, PositionDescription = "İnsan Kaynakları Uzmanı" },
                new Position { Id = 8, PositionDescription = "Yazılım Geliştirici" },
                new Position { Id = 9, PositionDescription = "Test Uzmanı" },
                new Position { Id = 10, PositionDescription = "Finans Uzmanı" },
                new Position { Id = 11, PositionDescription = "Pazarlama Uzmanı" },
                new Position { Id = 12, PositionDescription = "Doktor" },
                new Position { Id = 13, PositionDescription = "Hemşire" },
                new Position { Id = 14, PositionDescription = "Satış Temsilcisi" }

            );
        }
    }
}
