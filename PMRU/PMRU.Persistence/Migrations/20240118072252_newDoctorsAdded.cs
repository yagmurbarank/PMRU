using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newDoctorsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e08e981e-1832-4a85-88d2-c93cd89af009", "AQAAAAIAAYagAAAAEBt0vs0iXq+++pRPWxz2t/5FVkM1O6K/QqoUa3BLlDx7FmnMQU0H2ierQeP9/nDteQ==", "5c1eaa63-7fcd-4341-af4c-9d1764ac8d50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5223a490-b089-4e7a-bf6c-bcdf01a61a5e", "AQAAAAIAAYagAAAAEJsZky8sSeNCM6om30Mzjoq5izY0gm1UYynXYg5yFHxN9Ea+BnnpJnJ76B6skjg4pQ==", "ce319fe6-1577-4fec-869e-bdd5bc3d18a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "085b9ca4-2e3a-44b0-a770-58e98c9e7a8a", "AQAAAAIAAYagAAAAEMFFGP7l0oJ2oxkmrh2a68bzLiu4LWpyOV+Mp8D95WBHg1oB7t4gAMDWN5HvftxKMA==", "c5b46278-4d00-4103-81ea-9bdda3d33bc1" });

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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 3, null, "gulay.kaya@email.com", "12343458923", true, false, 72, "Gülay", "Password", "5556345678", "112", "Kaya" },
                    { 4, null, "gulsum.aydin@email.com", "12343458205", true, false, 34, "Gülsüm", "Password", "5556678901", "116", "Aydın" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 481, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 481, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "b38b5f59-4a70-45b9-9422-880dfccf3c4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "058b4814-ac76-45a1-a8f7-86f52b4fec52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "88e808f8-c318-4970-a46f-4024f151a489");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af515b61-7afe-407e-8eeb-9c703accc5fa", "AQAAAAIAAYagAAAAENi0XBpxUPaor0xWNzBqIPGRE1jlV6cvOlZuhR6hDWY6pFSGHbjKgesI/2gYOpK5gg==", "4ea6cdcc-4667-4af4-b9ca-0bd5aa813c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcd80ad6-681c-40e7-b079-0f9ff913e631", "AQAAAAIAAYagAAAAEKu4K4BaUvC2k14BL+uQjiCX+kfaPuk7dP4+7GAGAYiwaxWttCoESlvsYLUwO/d4Yw==", "c1d71fdb-abf8-481e-af08-e23d258089c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75bb1a6a-8cc7-4706-a8b3-a5305680e1a1", "AQAAAAIAAYagAAAAEOnLtvJ3cApjFSepv9F4LXcS9p5z7iOB1Y8D231ZjDViaGNal+vHZpJ3mtu7X3vosA==", "2cef4e2f-25c2-4f4f-bc01-055cb063d005" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 482, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(25));
        }
    }
}
