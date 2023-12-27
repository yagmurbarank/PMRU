using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence.Configurations
{
    public class SystemAdminConfiguration : IEntityTypeConfiguration<SystemAdmin>
    {
        public void Configure(EntityTypeBuilder<SystemAdmin> builder)
        {
            builder.Property(sa => sa.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(sa => sa.Surname)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(sa => sa.Phone)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(sa => sa.Email)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(sa => sa.Password)
                .HasMaxLength(50)
                .IsRequired();


            builder.HasData(
                new SystemAdmin { Id = 1, Name = "Elif", Surname = "Ersoy", Phone = "5555890123", Email = "elif.ersoy@email.com", Password = "adminpassword", IsActive = true, IsDeleted = false }
                // Add other system admins as needed
            );
        }
    }
}
