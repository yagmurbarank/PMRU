using Microsoft.AspNetCore.Identity;
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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData(
                 new User
                 {
                     Id = new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                     Email = "systemadmin@localhost.com",
                     NormalizedEmail = "SYSTEMADMIN@LOCALHOST.COM",
                     FullName = "System Admin",
                     UserName = "systemadmin@localhost.com",
                     NormalizedUserName = "SYSTEMADMIN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                     Email = "localadmin@localhost.com",
                     NormalizedEmail = "LOCALADMIN@LOCALHOST.COM",
                     FullName = "Local Admin",
                     UserName = "localadmin@localhost.com",
                     NormalizedUserName = "LOCALADMIN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                     Email = "doctor@localhost.com",
                     NormalizedEmail = "DOCTOR@LOCALHOST.COM",
                     FullName = "Doctor",
                     UserName = "doctor@localhost.com",
                     NormalizedUserName = "DOCTOR@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 }
            );
        }
    }
}
