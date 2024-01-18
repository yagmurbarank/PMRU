using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewAdminsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 724, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 724, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "44952f0b-d8f2-42ad-b1ca-fe5d5d8377c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "62256794-887b-4e60-9096-d68b93270bcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "97e10a8e-6724-4c92-81a1-b12737fdf95c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a4ea0bc9-47b2-4fc1-a1b9-2fd0351997a4", "cem.yildirim@email.com", "Cem Yıldırım", "CEM.YILDIRIM@EMAIL.COM", "CEM.YILDIRIM@EMAIL.COM", "AQAAAAIAAYagAAAAEOxRw7ELs3jwPGxYlbYpPzUJ6TJt5CuD9JDdWYNymZnz82kie7WoY6O08FZouLioLw==", "fbd9004a-778f-4fb1-a9b7-6d391c91cc3c", "cem.yildirim@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a699c491-1bb9-4da1-9e04-640a1effa8fd", "aylin.gunes@email.com", "Aylin Güneş", "AYLIN.GUNES@EMAIL.COM", "AYLIN.GUNES@EMAIL.COM", "AQAAAAIAAYagAAAAEMI45Ew1KiZyZy1wjRHKZQNivI6kxg05MKbZHtunC+8fF9QKiJwXsWySE/otzKO5xQ==", "6c69a3f7-4576-447f-b33f-57e9f4ff4f3f", "aylin.gunes@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "32ada948-5e3a-49fd-b412-2de429b8554f", "elif.ersoy@email.com", "Elif Ersoy", "ELIF.ERSOY@EMAIL.COM", "ELIF.ERSOY@EMAIL.COM", "AQAAAAIAAYagAAAAEBQorwkUiis6T4jB0x7XCadqo2vzstOm/7xe0pTFYy37wu7WhKWYIv4OSbucGzFayg==", "4233b8f8-b68a-4ead-985c-71d993beac52", "elif.ersoy@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"), 0, "34db62f3-4cf3-45bd-bb6e-77280b1cc7fd", "gulsum.aydin@email.com", false, "Gülsüm Aydın", false, null, "GULSUM.AYDIN@EMAIL.COM", "GULSUM.AYDIN@EMAIL.COM", "AQAAAAIAAYagAAAAEHX9JwpT8obTBW9/ErHy/OqTbM95+iq3H1ZUUPFWQuiyt2HZ11uSsDjw8Cf/kFxsBA==", null, false, null, null, "116", "709162aa-b49a-485e-a1e0-11253b11960a", false, "gulsum.aydin@email.com" },
                    { new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"), 0, "0097b68b-0dcb-42ce-a606-a8ff13fd1b3d", "emre.yaman@email.com", false, "Emre Yaman", false, null, "EMRE.YAMAN@EMAIL.COM", "EMRE.YAMAN@EMAIL.COM", "AQAAAAIAAYagAAAAEH8sWsGH/H8h9caYgpueWw/A19r31CEMCSQh1A7YGByQ95lel8f1uwZ80dTesJGVAg==", null, false, null, null, "117", "780450fa-f292-41c5-8d74-33f356fee6e2", false, "emre.yaman@email.com" },
                    { new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"), 0, "bf44bf9d-8ef2-409d-9746-2cbf669f75ba", "mert.saglam@email.com", false, "Mert Sağlam", false, null, "MERT.SAGLAM@EMAIL.COM", "MERT.SAGLAM@EMAIL.COM", "AQAAAAIAAYagAAAAEFmfMhNgRek1osyNJtGyYjPB2tRAxn64sFnGgkC7SSgv55sL9fpYjuQfIG36Y9RB5Q==", null, false, null, null, "115", "fd039f34-a09b-4e2c-a5d5-071aa2b7a509", false, "mert.saglam@email.com" },
                    { new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"), 0, "c46c30ae-318c-4d41-9ede-3e4d33cdef2b", "eren.akcay@email.com", false, "Eren Akçay", false, null, "EREN.AKCAY@EMAIL.COM", "EREN.AKCAY@EMAIL.COM", "AQAAAAIAAYagAAAAEKR5jjkz8eS/dPaIp2Ys/TVdUTDgUD4ASzVGZdeIEgDLLL3+NMg24bBt+ERLAKBb7Q==", null, false, null, null, "111", "56583fce-0dad-48f6-90fd-38f425f8ad13", false, "eren.akcay@email.com" },
                    { new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"), 0, "c39245f5-2006-4647-9a84-57a3f2412c1b", "gulay.kaya@email.com", false, "Gülay Kaya", false, null, "GULAY.KAYA@EMAIL.COM", "GULAY.KAYA@EMAIL.COM", "AQAAAAIAAYagAAAAECaMJAKaS77/drGFOwr95LTtrqacX6tKzsBkzh+JB6kerWzEZgQNBmv2CQiBpsOpbw==", null, false, null, null, "112", "4c816c31-b0a3-473e-a111-b3181eddea6c", false, "gulay.kaya@email.com" },
                    { new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"), 0, "55711f4d-866c-4637-8b40-79a5a5d2461a", "dilara.cetin@email.com", false, "Dilara Çetin", false, null, "DILARA.CETIN@EMAIL.COM", "DILARA.CETIN@EMAIL.COM", "AQAAAAIAAYagAAAAEIT/IS7/pz3NZ6guY/O3UvJC7EbyHdsGZ906x/VX8gtqD/R35gcfxqyyCLeC4zKhSA==", null, false, null, null, "114", "fc874370-b427-46d1-8322-0ce28f035e7a", false, "dilara.cetin@email.com" }
                });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "f99f284a-5b78-4362-b3a5-d0c6c4a4379c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "aeaf629c-30f3-4fba-9855-e2618c8535ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "af5e046e-a6da-4afe-a01f-0b8243fa5e59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e08e981e-1832-4a85-88d2-c93cd89af009", "localadmin@localhost.com", "Local Admin", "LOCALADMIN@LOCALHOST.COM", "LOCALADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBt0vs0iXq+++pRPWxz2t/5FVkM1O6K/QqoUa3BLlDx7FmnMQU0H2ierQeP9/nDteQ==", "5c1eaa63-7fcd-4341-af4c-9d1764ac8d50", "localadmin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5223a490-b089-4e7a-bf6c-bcdf01a61a5e", "doctor@localhost.com", "Doctor", "DOCTOR@LOCALHOST.COM", "DOCTOR@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJsZky8sSeNCM6om30Mzjoq5izY0gm1UYynXYg5yFHxN9Ea+BnnpJnJ76B6skjg4pQ==", "ce319fe6-1577-4fec-869e-bdd5bc3d18a0", "doctor@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "085b9ca4-2e3a-44b0-a770-58e98c9e7a8a", "systemadmin@localhost.com", "System Admin", "SYSTEMADMIN@LOCALHOST.COM", "SYSTEMADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMFFGP7l0oJ2oxkmrh2a68bzLiu4LWpyOV+Mp8D95WBHg1oB7t4gAMDWN5HvftxKMA==", "c5b46278-4d00-4103-81ea-9bdda3d33bc1", "systemadmin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 299, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 10, 22, 51, 301, DateTimeKind.Local).AddTicks(397));
        }
    }
}
