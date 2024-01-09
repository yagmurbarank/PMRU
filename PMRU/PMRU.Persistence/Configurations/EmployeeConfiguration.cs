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
                .HasForeignKey<Appointment>(e => e.EmployeeID)
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
                    PositionID = 3, 
                    DepartmentID = 4,
                    RegistrationNumber = "101",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 3,
                    IdentityNumber = "5278149630",
                    Name = "Mehmet",
                    Surname = "Çelik",
                    Phone = "(555) 534-5678",
                    Email = "mehmet.celik@email.com",
                    LocationID = 35,
                    PositionID = 5,
                    DepartmentID = 3,
                    RegistrationNumber = "102",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },

                new Employee
                {
                    Id = 4,
                    IdentityNumber = "5555456789",
                    Name = "Fatma",
                    Surname = "Arslan",
                    Phone = "(555) 545-6789",
                    Email = "fatma.arslan@email.com",
                    LocationID = 71,
                    PositionID = 6,
                    DepartmentID = 4,
                    RegistrationNumber = "103",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 5,
                    IdentityNumber = "5555567890",
                    Name = "Ali",
                    Surname = "Demir",
                    Phone = "(555) 556-7890",
                    Email = "ali.demir@email.com",
                    LocationID = 72,
                    PositionID = 2,
                    DepartmentID = 2,
                    RegistrationNumber = "104",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 6,
                    IdentityNumber = "5555678901",
                    Name = "Zeynep",
                    Surname = "Yıldız",
                    Phone = "(555) 567-8901",
                    Email = "zeynep.yildiz@email.com",
                    LocationID = 35,
                    PositionID = 14,
                    DepartmentID = 5,
                    RegistrationNumber = "105",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 7,
                    IdentityNumber = "5555789012",
                    Name = "Can",
                    Surname = "Aksoy",
                    Phone = "(555) 578-9012",
                    Email = "can.aksoy@email.com",
                    LocationID = 41,
                    PositionID = 4,
                    DepartmentID = 2,
                    RegistrationNumber = "106",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 8,
                    IdentityNumber = "5555890123",
                    Name = "Elif",
                    Surname = "Ersoy",
                    Phone = "(555) 589-0123",
                    Email = "elif.ersoy@email.com",
                    LocationID = 34,
                    PositionID = 8,
                    DepartmentID = 6,
                    RegistrationNumber = "107",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 9,
                    IdentityNumber = "5555901234",
                    Name = "Burak",
                    Surname = "Taşkın",
                    Phone = "(555) 590-1234",
                    Email = "burak.taskin@email.com",
                    LocationID = 72,
                    PositionID = 7,
                    DepartmentID = 4,
                    RegistrationNumber = "108",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                },
                new Employee
                {
                    Id = 10,
                    IdentityNumber = "5556012345",
                    Name = "Deniz",
                    Surname = "Akın",
                    Phone = "(555) 601-2345",
                    Email = "deniz.akin@email.com",
                    LocationID = 71,
                    PositionID = 2,
                    DepartmentID = 1,
                    RegistrationNumber = "109",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    DeletedDate = null
                }

            );
        }
    }
}
