using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewDoctorUsersAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 150, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 150, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "00593315-fbfc-4b4a-8037-07f96271e64b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "fba91d5f-f9d5-4251-b621-fbb057929277");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "a9f3523a-6100-4fd3-b9f7-1dbbe8416b59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5790552f-411a-4b26-bcbb-36c67d42ff2c", "AQAAAAIAAYagAAAAEKepaOTx1vW+L15mArEzBaK2T8VeG1sB9trmIo+ID5lhCJhWmDEOze47rv1hlVtZOQ==", "f8ac3893-29f4-4380-afd6-9223a8c00f80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e96f35a-d7eb-48c9-8a64-2f0d518b4ada", "AQAAAAIAAYagAAAAEOy/3Ug0Ml/tqGNYijwCkqhpuLtNhJ5j/1xgTI1G56IRGY+lbP9Fl0IgNECg/OWIhw==", "bec715d8-ed24-4818-bcf9-56515ac6d812" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc78796-7ebb-4f50-8710-884c0e6b4f89", "AQAAAAIAAYagAAAAEDFy7Z+lYwaP38CerTkQm/dERx2hlxyuQBT6V5iQCgo/BplS5s57plyY1/Sq0V8tOw==", "87d1e754-4481-47f3-ad11-4c75c3748529" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5949008-956f-490e-9570-605217584156", "AQAAAAIAAYagAAAAEJNSUaf/yWuPyhQxHfLDtppRM2LCRjdUthHf9pf2qyDjedUGZfYW6EUrb8Mv485OHA==", "768413a4-20ee-4308-981b-b121a379278a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc20e0ad-0b7f-4956-a237-ca3b9169d6eb", "AQAAAAIAAYagAAAAEPJhUA5HmsBXQzfn0Ft6piiL/QaBtkV3/+AtJlAL0BJqyBWu30IQj1Sy9P/M3EV6bg==", "25398df6-3cf6-4303-a45e-59d3ed6e001e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7050f308-1749-46d5-935e-b1b64a03bc7b", "AQAAAAIAAYagAAAAEPc9WJctAMzUdKwRfQ1qDIp5082ZzhTQU+oQ4++ZYM6U4cqXpXkzOG8XjJj9jWt9hQ==", "8b2a918c-ecde-4d63-9047-c6571066d152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75818ec0-b36a-4ae0-9464-4e2e9cbf1a73", "AQAAAAIAAYagAAAAEGK3aUbHqdi1WGsH6+2huYX6wbEqV9/p1ppWKU5YouyjdGor0SwH1eQsu5g5m1oisw==", "7eae0bb6-ef31-45db-8e93-f37cc431bf7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233812fa-83b1-48b8-aada-32ab15dc6b37", "AQAAAAIAAYagAAAAELCu6ps7f1O4sz0QNOpxhHZDiO4aBAGqEHu6c4r3GQE4xgYbTAGOYJcUk3N2w8R/Hg==", "fe3b95d6-89ee-48b0-8317-880b435c32cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aed2800-34e8-4235-b909-bf921675389c", "AQAAAAIAAYagAAAAEE1zmgM1nb/1CW43nlcjTJUumwxLEdInpSovQR8rfEtykesR6+GyFxJN0J4VlSgqVg==", "64069a09-43a4-4b34-bcd1-bba76f8fef75" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"), 0, "09e78e35-4d9c-4b30-90e4-9f075dafdc75", "meryem.kuzey@email.com", false, "Meryem Kuzey", false, null, "MERYEM.KUZEY@EMAIL.COM", "MERYEM.KUZEY@EMAIL.COM", "AQAAAAIAAYagAAAAECToJXgmsZJyX/ffdz5ndjmfuYgkXKrEL3luYzTP9Un+S3hQYhHtn36IYu3Zm/3fJw==", null, false, null, null, "121", "2acc3537-cd98-4fe1-8d6e-fe338f7cb778", false, "meryem.kuzey@email.com" },
                    { new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"), 0, "ce9f58a5-94eb-42a4-b967-21a5c28b6ba3", "ali.atabey@email.com", false, "Ali Atabey", false, null, "ALI.ATABEY@EMAIL.COM", "ALI.ATABEY@EMAIL.COM", "AQAAAAIAAYagAAAAEKmCabzRGYKum95YFjhL14K7qUYg77/44sQFJajBahDlyXypN8Yw8+Ut6OyCVYrkrQ==", null, false, null, null, "122", "22e7033e-2083-42d1-9059-15358855468d", false, "ali.atabey@email.comm" }
                });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 151, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 20, 9, 19, 152, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "dcdd12af-3e7e-4ae5-879e-ebe7df277355");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "a599d9b6-c5d3-445e-a28b-035b86ceddc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "07149a21-2545-40b8-a2d4-61e4dc6fb6d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761fcf7e-d88d-4f58-97e6-9bc0ecc84e84", "AQAAAAIAAYagAAAAELUKB9aRQLmfQPguVobwC7hTgs+1In39JagSg2obRyvEbMXUSAp+n5Zaypf1HzenWw==", "a50b652e-3382-4896-974c-2cfb4d984407" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dd7612-44c9-415e-a234-631bc92c557d", "AQAAAAIAAYagAAAAECzQnzBSjkHs21PzzjQiZ8t7keKEfCil8ZJBbFakPbc2DMCGHeQ85CWXkD9HvDjHeQ==", "59b7fc55-905e-4fe6-9be3-00cf5a4aa65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a5db2f7-d777-4914-add6-e0a0cada38ec", "AQAAAAIAAYagAAAAEFmCwQdQMoEMQG2jpCVLSlxxEPavTZVbeY4IsMdUYkT970dvJXcnVEvXGRBKw5WprQ==", "e5174d56-223d-4496-9414-c36096efb30f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3de5aa-80ee-41f5-84bb-9b151d6f3593", "AQAAAAIAAYagAAAAEKt0KcMn2CVeTEv7j1j4Hx3RVCIHh/KnH+Uv+S0YjTVAjUYssHaR0v+2ohJ7ohkYXw==", "57e2e56c-6e6b-4835-be3d-2604932571a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "319d9698-ee44-4046-b6bd-47c14260df87", "AQAAAAIAAYagAAAAEGzaUbJwhn3+W+tgshDDS3aveZP7sR3hx6FTVpT6tfqlcUVH5MLdTypjUS3fzZHzkg==", "279ff61b-efe0-4932-a99e-2ff372db83b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7753ee68-cb02-4ee5-bd78-e9fa104d8601", "AQAAAAIAAYagAAAAENO9sTwZIo3HvsoWd4kUauvqeXOOPt0vTRV//B1OhBBCbbxrehUW6PabyYM8Um2rLw==", "35391354-0b5d-4806-97bc-e935dbfcbac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8816f7d-2a8a-4d9f-8fa1-48b78190a142", "AQAAAAIAAYagAAAAELZDeEysCdsqhTwOv3Fkv2B8F9mnpxDeCZiCR50kSKmlx0C9Fm7O50TvVT18wbzV3A==", "1ca13596-79bd-4da6-b76d-a957a0c5144a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac1e60c-7ae6-4533-ba2b-0666c0294418", "AQAAAAIAAYagAAAAEFFLAA4q0Va5JzVFeiUgDZylJ8qoqvWju/bsEv/V91wc5p9rFn+X7OS1qCgR/UlY/A==", "7e68d724-4ee6-4c33-b367-846a69075f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839adf3e-bdbb-44f8-b761-39ab8a4805c1", "AQAAAAIAAYagAAAAEOMtvVkWf7kv4JQeLgnOKZNL9Wiy5TCs2iE3RmgYkcjmdBxekWf2IxNxtugeph/NZg==", "eb43a5f0-b1ac-4b64-ab4c-59c1e022f21b" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2213));
        }
    }
}
