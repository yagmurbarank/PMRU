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
                     Email = "elif.ersoy@email.com",
                     NormalizedEmail = "ELIF.ERSOY@EMAIL.COM",//SYSTEMADMIN
                     FullName = "Elif Ersoy",
                     RegistrationNumber = "107",
                     UserName = "elif.ersoy@email.com",
                     NormalizedUserName = "ELIF.ERSOY@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                     Email = "aylin.gunes@email.com",
                     NormalizedEmail = "AYLIN.GUNES@EMAIL.COM",//DOCTOR
                     FullName = "Aylin Güneş",
                     RegistrationNumber = "110",
                     UserName = "aylin.gunes@email.com",
                     NormalizedUserName = "AYLIN.GUNES@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User 
                 {
                     Id = new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                     Email = "eren.akcay@email.com",
                     NormalizedEmail = "EREN.AKCAY@EMAIL.COM",//DOCTOR
                     FullName = "Eren Akçay",
                     RegistrationNumber = "111",
                     UserName = "eren.akcay@email.com",
                     NormalizedUserName = "EREN.AKCAY@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                     Email = "gulay.kaya@email.com",
                     NormalizedEmail = "GULAY.KAYA@EMAIL.COM",//DOCTOR
                     FullName = "Gülay Kaya",
                     RegistrationNumber = "112",
                     UserName = "gulay.kaya@email.com",
                     NormalizedUserName = "GULAY.KAYA@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                     Email = "gulsum.aydin@email.com",
                     NormalizedEmail = "GULSUM.AYDIN@EMAIL.COM",//DOCTOR
                     FullName = "Gülsüm Aydın",
                     RegistrationNumber = "116",
                     UserName = "gulsum.aydin@email.com",
                     NormalizedUserName = "GULSUM.AYDIN@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                     Email = "cem.yildirim@email.com",
                     NormalizedEmail = "CEM.YILDIRIM@EMAIL.COM",//LOCALADMIN
                     FullName = "Cem Yıldırım",
                     RegistrationNumber = "113",
                     UserName = "cem.yildirim@email.com",
                     NormalizedUserName = "CEM.YILDIRIM@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                     Email = "dilara.cetin@email.com",
                     NormalizedEmail = "DILARA.CETIN@EMAIL.COM",//LOCALADMIN
                     FullName = "Dilara Çetin",
                     RegistrationNumber = "114",
                     UserName = "dilara.cetin@email.com",
                     NormalizedUserName = "DILARA.CETIN@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                     Email = "mert.saglam@email.com",
                     NormalizedEmail = "MERT.SAGLAM@EMAIL.COM",//LOCALADMIN
                     FullName = "Mert Sağlam",
                     RegistrationNumber = "115",
                     UserName = "mert.saglam@email.com",
                     NormalizedUserName = "MERT.SAGLAM@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 },
                 new User
                 {
                     Id = new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                     Email = "emre.yaman@email.com",
                     NormalizedEmail = "EMRE.YAMAN@EMAIL.COM",//LOCALADMIN
                     FullName = "Emre Yaman",
                     RegistrationNumber = "117",
                     UserName = "emre.yaman@email.com",
                     NormalizedUserName = "EMRE.YAMAN@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                 }
            );
        }
    }
}
