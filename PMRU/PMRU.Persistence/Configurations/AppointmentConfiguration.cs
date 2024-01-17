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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);


            // Employee ile ilişki
            builder.HasOne(a => a.Employee)
                .WithOne(e => e.Appointment)
                .HasForeignKey<Appointment>(a => a.EmployeeID)
                .HasPrincipalKey<Employee>(e => e.Id)  // Anahtar alan Employee sınıfındaki Id
                .OnDelete(DeleteBehavior.Restrict);

            // Doctor ile ilişki
            builder.HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorID)
                .OnDelete(DeleteBehavior.Restrict);

            // Diğer alanlar
            builder.Property(a => a.AppointmentDate).IsRequired();
            builder.Property(a => a.AppointmentStartHour).IsRequired();
            builder.Property(a => a.AppointmentEndHour).IsRequired();
            builder.Property(a => a.Description).IsRequired();
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

            // Çalışanın aynı anda sadece bir randevuya sahip olma kuralı
            builder.HasIndex(a => a.EmployeeID).IsUnique();

            builder.HasData(
                new Appointment
                {
                    Id = 1,
                    EmployeeID = 1,
                    DoctorID = 1,
                    AppointmentDate = new DateOnly(2023,11,12),
                    AppointmentStartHour = new TimeOnly(12,30),
                    AppointmentEndHour = new TimeOnly(12, 50),
                    Description = "Regular Checkup"
                },
                new Appointment
                {
                    Id = 2,
                    EmployeeID = 2,
                    DoctorID = 2,
                    AppointmentDate = new DateOnly(2023, 12, 13),
                    AppointmentStartHour = new TimeOnly(13, 45),
                    AppointmentEndHour = new TimeOnly(14, 00),
                    Description = "Regular Checkup"
                }
                );

            
        }
    }
}
