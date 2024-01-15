using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("01b33042-952a-4636-8d15-682447de311a"),
                    UserId = new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                    UserId = new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                    UserId = new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8")
                }
            );
        }
    }
}
