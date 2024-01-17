using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentEndHourAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorID_AppointmentDate_AppointmentHour",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "AppointmentHour",
                table: "Appointments",
                newName: "AppointmentStartHour");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "AppointmentEndHour",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentEndHour", "CreatedDate" },
                values: new object[] { new TimeOnly(12, 50, 0), new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentEndHour", "CreatedDate" },
                values: new object[] { new TimeOnly(14, 0, 0), new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "fc888c41-effa-4991-b8d5-e03958b10171");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "301901d0-a79f-44da-95cf-c07c2f04faee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "b8372022-0d53-4f38-9ac5-06128e4bf0c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e63324c-add9-45cb-8407-d45d8d6ae19a", "AQAAAAIAAYagAAAAEPxP+YiJ3ZBlH0oLSGTvancASu0CoLYAzC/i6sw9YBEnZMN6fVRdm4wbpHpqRuXL9Q==", "c0a67ee3-5e0b-4df1-a115-78ec4050e9a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "042c4a73-dcd5-4a28-9764-d68026183730", "AQAAAAIAAYagAAAAEF/847m4U3lxzjD5x4gzXh10spvHc/N4SwowPwJmzG8gdO92o3WqH+5hMrnZjEQ2vQ==", "2eb514c2-5753-4dde-8f96-13d92e03e09a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7303badd-1301-4334-bf4e-c3247dcc067e", "AQAAAAIAAYagAAAAEAIQ37c7YcmvjcwvWBLZSAF+HQULIgVm005QD7ul+D6TpB+nciQobFQ5sxg1ySU8UQ==", "9da9b638-3f2c-4656-9e9a-549b6c352344" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments",
                column: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentEndHour",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "AppointmentStartHour",
                table: "Appointments",
                newName: "AppointmentHour");

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
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 16, 16, 41, 47, 210, DateTimeKind.Local).AddTicks(576));

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorID_AppointmentDate_AppointmentHour",
                table: "Appointments",
                columns: new[] { "DoctorID", "AppointmentDate", "AppointmentHour" },
                unique: true);
        }
    }
}
