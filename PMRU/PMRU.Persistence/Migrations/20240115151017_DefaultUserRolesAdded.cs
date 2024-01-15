using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DefaultUserRolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), "5f787b8d-4354-4e54-b3a7-81b6998e3005", "SystemAdmin", "SYSTEMADMIN" },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), "8effe541-cf2b-444f-b4ce-4ea29c18d3bd", "LocalAdmin", "LOCALADMIN" },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), "c8de1c5f-61d9-4293-871e-3951d19fabdb", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"), 0, "8d45d3f7-9189-4346-a514-58088823dd1c", "localadmin@localhost.com", false, "Local Admin", false, null, "LOCALADMIN@LOCALHOST.COM", "LOCALADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA3DfpK9fhu8DIfLbUWEuAswD5KuQEIkYp9JqhVIEjDm2mOMZqFY+w4c5DqeFOg7BQ==", null, false, null, null, "c75faad5-1ac2-4861-ae68-7695b7216e87", false, "localadmin@localhost.com" },
                    { new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"), 0, "b560da33-1be3-4855-8da6-dcf00e05afcb", "doctor@localhost.com", false, "Doctor", false, null, "DOCTOR@LOCALHOST.COM", "DOCTOR@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJZyTG2bizNnMYUx3Ip39pAUJ+J6TPQKbIZ7J4fufdP81LepHew29pEBEN/tfBaBcA==", null, false, null, null, "1047d53d-b781-4016-8492-dd02aac7391e", false, "doctor@localhost.com" },
                    { new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"), 0, "8e03a755-edfc-4f25-a2a5-b51e7688c5c9", "systemadmin@localhost.com", false, "System Admin", false, null, "SYSTEMADMIN@LOCALHOST.COM", "SYSTEMADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELXMsyL4upAReyPLzJa9W8CuW8MyRi6XCTTuT+nfQzXgkb+CxeoUgxNJ6pEPKKPTuA==", null, false, null, null, "935cdeeb-0091-4155-b89d-67c6c967c3eb", false, "systemadmin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 10, 17, 145, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8") },
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("01b33042-952a-4636-8d15-682447de311a"), new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 1, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 1, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 2, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 2, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 9, 46, 3, 3, DateTimeKind.Local).AddTicks(4381));
        }
    }
}
