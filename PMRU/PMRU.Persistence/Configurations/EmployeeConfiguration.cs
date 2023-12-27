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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.IdentityNumber).HasMaxLength(11).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Surname).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Phone).HasMaxLength(15).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(255).IsRequired();
            builder.Property(e => e.RegistrationNumber).HasMaxLength(20).IsRequired();

            builder.HasOne(e => e.Location)
                .WithMany()
                .HasForeignKey(e => e.LocationID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Role)
                .WithMany()
                .HasForeignKey(e => e.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Position)
                .WithMany()
                .HasForeignKey(e => e.PositionID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Appointment)
                .WithOne(a => a.Employee)
                .HasForeignKey<Employee>(e => e.Appointment)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Employee
                {
                    Id = 1,
                    IdentityNumber = "5555123456",
                    Name = "Ahmet",
                    Surname = "Yılmaz",
                    Phone = "(555) 512-3456",
                    Email = "ahmet.yilmaz@email.com",
                    LocationID = 34,
                    RoleID = 4, 
                    PositionID = 4, 
                    DepartmentID = 4,
                    RegistrationNumber = "100",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 2,
                    IdentityNumber = "5555234567",
                    Name = "Ayşe",
                    Surname = "Kaya",
                    Phone = "(555) 523-4567",
                    Email = "ayse.kaya@email.com",
                    LocationID = 41,
                    RoleID = 4, 
                    PositionID = 3, 
                    DepartmentID = 4,
                    RegistrationNumber = "101",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                }

            );
        }
    }
}
