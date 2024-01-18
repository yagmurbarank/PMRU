using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewEmployeesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "af515b61-7afe-407e-8eeb-9c703accc5fa", "AQAAAAIAAYagAAAAENi0XBpxUPaor0xWNzBqIPGRE1jlV6cvOlZuhR6hDWY6pFSGHbjKgesI/2gYOpK5gg==", "113", "4ea6cdcc-4667-4af4-b9ca-0bd5aa813c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "fcd80ad6-681c-40e7-b079-0f9ff913e631", "AQAAAAIAAYagAAAAEKu4K4BaUvC2k14BL+uQjiCX+kfaPuk7dP4+7GAGAYiwaxWttCoESlvsYLUwO/d4Yw==", "110", "c1d71fdb-abf8-481e-af08-e23d258089c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "75bb1a6a-8cc7-4706-a8b3-a5305680e1a1", "AQAAAAIAAYagAAAAEOnLtvJ3cApjFSepv9F4LXcS9p5z7iOB1Y8D231ZjDViaGNal+vHZpJ3mtu7X3vosA==", "107", "2cef4e2f-25c2-4f4f-bc01-055cb063d005" });

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
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationNumber",
                value: "110");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationNumber",
                value: "111");

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 11, 0, new DateTime(2024, 1, 18, 9, 59, 25, 483, DateTimeKind.Local).AddTicks(9987), null, 7, "aylin.gunes@email.com", "5642597451", true, false, 35, "Aylin", "(555) 612-3456", 12, "110", "Güneş" },
                    { 12, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(4), null, 7, "eren.akcay@email.com", "5642517451", true, false, 41, "Eren", "(555) 623-4567", 12, "111", "Akçay" },
                    { 13, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(7), null, 7, "gulay.kaya@email.com", "3462517451", true, false, 72, "Gülay", "(555) 634-5678", 12, "112", "Kaya" },
                    { 14, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(9), null, 7, "cem.yildirim@email.com", "3434517451", true, false, 35, "Cem", "(555) 645-6789", 13, "113", "Yıldırım" },
                    { 15, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(11), null, 7, "dilara.cetin@email.com", "3434546751", true, false, 72, "Dilara", "(555) 656-7890", 13, "114", "Çetin" },
                    { 16, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(14), null, 7, "mert.saglam@email.com", "3432209751", true, false, 41, "Mert", "(535) 896-4526", 13, "115", "Sağlam" },
                    { 17, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(16), null, 7, "gulsum.aydin@email.com", "3432906751", true, false, 34, "Gülsüm", "(555) 667-8901", 12, "116", "Aydın" },
                    { 18, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(18), null, 7, "emre.yaman@email.com", "3850906751", true, false, 34, "Emre", "(555) 678-9012", 13, "117", "Yaman" },
                    { 19, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(21), null, 5, "selin.erdogan@email.com", "3850915851", true, false, 41, "Selin", "(555) 689-0123", 11, "118", "Erdoğan" },
                    { 20, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(23), null, 3, "onur.akbas@email.com", "3850926751", true, false, 35, "Onur", "(555) 690-1234", 10, "119", "Akbaş" },
                    { 21, 0, new DateTime(2024, 1, 18, 9, 59, 25, 484, DateTimeKind.Local).AddTicks(25), null, 6, "melis.yilmaz@email.com", "3880226751", true, false, 34, "Melis", "(555) 701-2345", 9, "120", "Yılmaz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "c09f765e-b18e-4160-8a50-92f1cfed0e44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "9e6aaef6-32b6-46e0-9411-8fc576b5b7fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "7b9cfe33-7050-4a98-b769-bcdaa7a9cf4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "790814b3-4306-4e98-a36d-69ff8d06d00c", "AQAAAAIAAYagAAAAEHi+eJLVwC3lomaVD68lWUEgVNR6axYkMSJigJDvVjElJS3JKUvorzLdk2C+0VQYaA==", "101", "4e9d7f52-c907-4958-917a-ae66a978da1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "8001291b-eb25-4b58-8880-04f8d4de3248", "AQAAAAIAAYagAAAAEKgqDEJ+0ZdxNyvtUQBD++d/K4XIScvW/z7buDfHiiRGftIssNH4Fnw8S7GxNHlYyw==", "102", "5d425bed-717a-4e52-a1b5-2fc1d05de1ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationNumber", "SecurityStamp" },
                values: new object[] { "6d0a00bd-3341-4938-af73-0dd37d2f12bd", "AQAAAAIAAYagAAAAEDaPct6UwUiMoxhed/OeFJklgIWn70aZQiLwXJsyqj5BxBwE7Y36SsMaL6QYRDJhgQ==", "100", "949f74ff-1266-4f89-a4e0-05d66450ce21" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationNumber",
                value: "102");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationNumber",
                value: "103");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3030));
        }
    }
}
