using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RegistrationNumberAddedToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "39bd2e6e-c3bb-4db3-8f28-c4754330b4e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "687764fe-3990-4056-a283-b5203dff8983");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "c550951c-51bd-4ac0-9a2e-96c2f70d53f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "a062044a-dafd-4037-bbdd-a1b35a63bd92", "AQAAAAIAAYagAAAAEP6K3NGN7t8Ofdjb+xNYvMWrNazA193kaH4//84AgNblbENc90flddE5rOWAz35XnA==", "101", "dfc4b8df-ec8d-4cdb-a70e-fdf54d016029" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "d6407378-cc76-4e1c-89e0-d698e897c916", "AQAAAAIAAYagAAAAEHq0pfVX5abpS9rU3XQm7lV/0yeZv1tWHr52nCwAMQxjCMOjkWQuqRKrvxzQnjwSgQ==", "102", "c62f0d9b-c25e-420f-93cc-2c103e85d1c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "5ae78e91-b52b-4c96-a6be-709e107f9a3c", "AQAAAAIAAYagAAAAEOcnJFz+QoxvnVuoYi6h7x/w7eev6jjf37hwCJYYGWeJAw3tlS7w5uJhGhv/UZGPMw==", "100", "bb6d8503-c952-40a3-acc3-6914a82ef8ea" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 15, 18, 41, 10, 107, DateTimeKind.Local).AddTicks(4338));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "5f787b8d-4354-4e54-b3a7-81b6998e3005");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "8effe541-cf2b-444f-b4ce-4ea29c18d3bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "c8de1c5f-61d9-4293-871e-3951d19fabdb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d45d3f7-9189-4346-a514-58088823dd1c", "AQAAAAIAAYagAAAAEA3DfpK9fhu8DIfLbUWEuAswD5KuQEIkYp9JqhVIEjDm2mOMZqFY+w4c5DqeFOg7BQ==", "c75faad5-1ac2-4861-ae68-7695b7216e87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b560da33-1be3-4855-8da6-dcf00e05afcb", "AQAAAAIAAYagAAAAEJZyTG2bizNnMYUx3Ip39pAUJ+J6TPQKbIZ7J4fufdP81LepHew29pEBEN/tfBaBcA==", "1047d53d-b781-4016-8492-dd02aac7391e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e03a755-edfc-4f25-a2a5-b51e7688c5c9", "AQAAAAIAAYagAAAAELXMsyL4upAReyPLzJa9W8CuW8MyRi6XCTTuT+nfQzXgkb+CxeoUgxNJ6pEPKKPTuA==", "935cdeeb-0091-4155-b89d-67c6c967c3eb" });

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
        }
    }
}
