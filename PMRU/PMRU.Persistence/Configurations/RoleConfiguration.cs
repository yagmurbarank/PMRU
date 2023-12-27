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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.RoleDescription).HasMaxLength(255).IsRequired();

            builder.HasData(
                new Role { Id = 1, RoleDescription = "SystemAdmin" },
                new Role { Id = 2, RoleDescription = "LocalAdmin" },
                new Role { Id = 3, RoleDescription = "Doctor" },
                new Role { Id = 4, RoleDescription = "Employee" }
            );
        }
    }
}
