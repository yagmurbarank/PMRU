using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AvailabilityDataTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Availabilities");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Availabilities",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 209, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 209, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "62d000ab-eafa-455c-86a8-9bd691525d25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "aa2688b3-56a5-4cf0-ba28-e786888e9410");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "780fef47-ba8c-4b04-84b3-962e8e0eb457");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb8b763-476f-4d1c-a575-b990c91e8f5f", "AQAAAAIAAYagAAAAECfsZHos/V62h+US2mRsGG7pHHoPSfyuIXtYsgSGuZLYVFyiwE9b7RYgCVAWraGCLA==", "27decfe1-0e3c-4746-8c4c-fd3a83fceba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d44031-a8f7-47e0-b9b5-124da8e95415", "AQAAAAIAAYagAAAAECx+Fa7OxUxOtRTOUiY017SCVQTys/BVJSQ7gJhmCi57HRL3KFkToAPFEJcQJ4Y9XQ==", "d1dca257-4143-4e92-b140-dc7a4d11918a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93b0bfb9-1158-4a54-8fa4-71c02c8e0033", "AQAAAAIAAYagAAAAEGgJGgN3BEwRJyS5tiZSGN/nNUlBEE286rMaz4hlQguqczHdJh8fpVBCvbq1hRCWBg==", "6b492d63-c3a7-4cf4-a300-8fe05418b7ae" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(570), new DateOnly(2024, 1, 17), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(576), new DateOnly(2024, 1, 17), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(5005));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Availabilities");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Availabilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a062044a-dafd-4037-bbdd-a1b35a63bd92", "AQAAAAIAAYagAAAAEP6K3NGN7t8Ofdjb+xNYvMWrNazA193kaH4//84AgNblbENc90flddE5rOWAz35XnA==", "dfc4b8df-ec8d-4cdb-a70e-fdf54d016029" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6407378-cc76-4e1c-89e0-d698e897c916", "AQAAAAIAAYagAAAAEHq0pfVX5abpS9rU3XQm7lV/0yeZv1tWHr52nCwAMQxjCMOjkWQuqRKrvxzQnjwSgQ==", "c62f0d9b-c25e-420f-93cc-2c103e85d1c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ae78e91-b52b-4c96-a6be-709e107f9a3c", "AQAAAAIAAYagAAAAEOcnJFz+QoxvnVuoYi6h7x/w7eev6jjf37hwCJYYGWeJAw3tlS7w5uJhGhv/UZGPMw==", "bb6d8503-c952-40a3-acc3-6914a82ef8ea" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Day", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(9558), 1, new TimeSpan(0, 8, 20, 0, 0), new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Day", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 18, 41, 10, 106, DateTimeKind.Local).AddTicks(9574), 2, new TimeSpan(0, 8, 20, 0, 0), new TimeSpan(0, 8, 0, 0, 0) });

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
    }
}
