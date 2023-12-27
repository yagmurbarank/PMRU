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
    public class LocalAdminConfiguration : IEntityTypeConfiguration<LocalAdmin>
    {
        public void Configure(EntityTypeBuilder<LocalAdmin> builder)
        {
            builder.Property(la => la.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(la => la.Surname)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(la => la.Phone)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(la => la.Email)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(la => la.Password)
                .HasMaxLength(50)
                .IsRequired();


            // Seed data if necessary
            builder.HasData(
                new LocalAdmin { Id = 1, Name = "Cem", Surname = "Yıldırım", Phone = "5556456789", Email = "cem.yildirim@email.com", Password = "password123", IsActive = true, IsDeleted = false }
                // Add other local admins as needed
            );
        }
    }
}
