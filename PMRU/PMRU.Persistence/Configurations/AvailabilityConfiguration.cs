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
    public class AvailabilityConfiguration : IEntityTypeConfiguration<Availability>
    {
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.HasKey(a => a.Id);

            // Doctor ile ilişki
            builder.HasOne(a => a.Doctor)
                .WithMany(d => d.Availabilities)
                .HasForeignKey(a => a.DoctorID)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.Property(a => a.Day).IsRequired();
            builder.Property(a => a.StartTime).IsRequired();
            builder.Property(a => a.EndTime).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.LastModifiedDate);

            // BaseEntity sınıfından gelen alanlar
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.DeletedDate);

            // Oluşturulan tarih alanlarını varsayılan değerlerle ayarlama
            builder.Property(a => a.CreatedDate).HasDefaultValueSql("GETDATE()");
            builder.Property(a => a.LastModifiedDate).HasDefaultValue(null);
            builder.Property(a => a.DeletedDate).HasDefaultValue(null);

            // Gün ve saat aralığı için benzersiz indeks oluşturma
            // builder.HasIndex(a => new { a.DoctorID, a.Day, a.StartTime, a.EndTime }).IsUnique();

            builder.HasData(
                new Availability
                {
                    Id = 1,
                    DoctorID = 1,
                    Day = DayOfWeek.Monday,
                    StartTime = TimeSpan.FromHours(8),
                    EndTime = TimeSpan.FromHours(8) + TimeSpan.FromMinutes(20)
        },
                new Availability
                {
                    Id = 2,
                    DoctorID = 2,
                    Day = DayOfWeek.Tuesday,
                    StartTime = TimeSpan.FromHours(8),
                    EndTime = TimeSpan.FromHours(8) + TimeSpan.FromMinutes(20)
                }
                );
        }
    }
}
