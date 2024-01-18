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
                    RoleId = new Guid("01b33042-952a-4636-8d15-682447de311a"),//systemadmin
                    UserId = new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09")//regno:107
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),//doctor
                    UserId = new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8")//regno:110
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),//doctor
                    UserId = new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11")//regno:111
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),//doctor
                    UserId = new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68")//regno:112
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),//doctor
                    UserId = new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3")//regno:116
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),//localadmin
                    UserId = new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb")//regno:113
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),//localadmin
                    UserId = new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09")//regno:114
                },
                new IdentityUserRole<Guid> 
                {
                    RoleId = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),//localadmin
                    UserId = new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f")//regno:115
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),//localadmin
                    UserId = new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91")//regno:117
                }
            );
        }
    }
}
