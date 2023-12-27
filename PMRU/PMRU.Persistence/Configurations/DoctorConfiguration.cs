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
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(10); 
            builder.Property(x => x.IdentityNumber).HasMaxLength(11).IsRequired(); 
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired(); 


            builder.HasOne(d => d.Employee)
                .WithOne(e => e.Doctor)
                .HasForeignKey<Doctor>(d => d.DoctorID);

            builder.HasMany(d => d.Appointments)
                .WithOne(a => a.Doctor)
                .HasForeignKey(a => a.DoctorID);

            builder.HasMany(d => d.Availabilities)
                .WithOne(a => a.Doctor)
                .HasForeignKey(a => a.DoctorID);

            builder.HasOne(d => d.Location)
                .WithMany()
                .HasForeignKey(d => d.LocationID);

            builder.HasOne(d => d.Role)
                .WithMany()
                .HasForeignKey(d => d.RoleID);

            builder.HasOne(d => d.Position)
                .WithMany()
                .HasForeignKey(d => d.PositionID);

            builder.HasOne(d => d.Department)
                .WithMany()
                .HasForeignKey(d => d.DepartmentID);



            builder.HasData(
                new Doctor
                {
                    DoctorID = 1,
                    Name = "Aylin",
                    Surname = "Güneş",
                    Email = "aylin.gunes@email.com",
                    Phone = "5556123456",
                    IdentityNumber = "12345678901",
                    LocationID = 35,
                    RoleID = 3,    
                    PositionID = 12,
                    DepartmentID = 7,
                },
                new Doctor
                {
                    DoctorID = 1,
                    Name = "Eren",
                    Surname = "Akçay",
                    Email = "eren.akcay@email.com",
                    Phone = "5556234567",
                    IdentityNumber = "12345678923",
                    LocationID = 41,
                    RoleID = 3,
                    PositionID = 12,
                    DepartmentID = 7,
                }
                // Doktor eklenebilir.
            );
        }
    }
}
