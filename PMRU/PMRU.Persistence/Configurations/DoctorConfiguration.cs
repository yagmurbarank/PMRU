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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(10); 
            builder.Property(x => x.IdentityNumber).HasMaxLength(11).IsRequired(); 
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired(); 

            builder.HasMany(d => d.Appointments)
                .WithOne(a => a.Doctor)
                .HasForeignKey(a => a.DoctorID)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.Availabilities)
                .WithOne(a => a.Doctor)
                .HasForeignKey(a => a.DoctorID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Location)
                .WithMany()
                .HasForeignKey(d => d.LocationID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Aylin",
                    Surname = "Güneş",
                    Email = "aylin.gunes@email.com",
                    Phone = "5556123456",
                    IdentityNumber = "12345678901",
                    RegistrationNumber = "110",
                    LocationID = 35,
                    Password = "Password"
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Eren",
                    Surname = "Akçay",
                    Email = "eren.akcay@email.com",
                    Phone = "5556234567",
                    IdentityNumber = "12345678923",
                    RegistrationNumber = "111",
                    LocationID = 41,
                    Password = "Password"
                }
            );
        }
    }
}
