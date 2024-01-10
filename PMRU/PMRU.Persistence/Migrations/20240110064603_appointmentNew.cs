using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class appointmentNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentID",
                table: "Appointments");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentID",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentID", "CreatedDate" },
                values: new object[] { 12, new DateTime(2024, 1, 9, 15, 22, 13, 109, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentID", "CreatedDate" },
                values: new object[] { 13, new DateTime(2024, 1, 9, 15, 22, 13, 109, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 110, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 110, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3496));
        }
    }
}
