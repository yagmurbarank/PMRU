using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MoreEmployeeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 109, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 15, 22, 13, 109, DateTimeKind.Local).AddTicks(7876));

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 3, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3478), null, 3, "mehmet.celik@email.com", "5278149630", true, false, 35, "Mehmet", "(555) 534-5678", 5, "102", "Çelik" },
                    { 4, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3481), null, 4, "fatma.arslan@email.com", "5555456789", true, false, 71, "Fatma", "(555) 545-6789", 6, "103", "Arslan" },
                    { 5, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3483), null, 2, "ali.demir@email.com", "5555567890", true, false, 72, "Ali", "(555) 556-7890", 2, "104", "Demir" },
                    { 6, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3485), null, 5, "zeynep.yildiz@email.com", "5555678901", true, false, 35, "Zeynep", "(555) 567-8901", 14, "105", "Yıldız" },
                    { 7, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3489), null, 2, "can.aksoy@email.com", "5555789012", true, false, 41, "Can", "(555) 578-9012", 4, "106", "Aksoy" },
                    { 8, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3491), null, 6, "elif.ersoy@email.com", "5555890123", true, false, 34, "Elif", "(555) 589-0123", 8, "107", "Ersoy" },
                    { 9, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3494), null, 4, "burak.taskin@email.com", "5555901234", true, false, 72, "Burak", "(555) 590-1234", 7, "108", "Taşkın" },
                    { 10, 0, new DateTime(2024, 1, 9, 15, 22, 13, 111, DateTimeKind.Local).AddTicks(3496), null, 1, "deniz.akin@email.com", "5556012345", true, false, 71, "Deniz", "(555) 601-2345", 2, "109", "Akın" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 83, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 83, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 83, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 83, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 84, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 9, 0, 36, 20, 84, DateTimeKind.Local).AddTicks(9309));
        }
    }
}
