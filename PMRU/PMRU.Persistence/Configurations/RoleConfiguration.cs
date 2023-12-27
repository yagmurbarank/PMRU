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
            builder.HasKey(r => r.RoleID);
            builder.Property(r => r.RoleDescription).HasMaxLength(255).IsRequired();

            builder.HasData(
                new Role { RoleID = 1, RoleDescription = "SystemAdmin" },
                new Role { RoleID = 2, RoleDescription = "LocalAdmin" },
                new Role { RoleID = 3, RoleDescription = "Doctor" },
                new Role { RoleID = 4, RoleDescription = "Employee" }
            );
        }
    }
}
