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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = new Guid("01b33042-952a-4636-8d15-682447de311a"),
                    Name = "SystemAdmin",
                    NormalizedName = "SYSTEMADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new Role
                {
                    Id = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                    Name = "LocalAdmin",
                    NormalizedName = "LOCALADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new Role
                {
                    Id = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                    Name = "Doctor",
                    NormalizedName = "DOCTOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                }
            );
        }
    }
}
