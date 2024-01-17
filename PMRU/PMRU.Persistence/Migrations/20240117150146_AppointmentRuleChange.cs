using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentRuleChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "550d4223-ae6c-4a6c-933f-11349ef18e5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "8ae492fe-f931-40a0-8550-af132c024cff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "c31e93a5-5f89-4d07-b475-cd5d41b4a19c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871327fd-99ff-4ec9-82dd-b69c934676df", "AQAAAAIAAYagAAAAEEUUhv014r+CSigq746fdfuHd42gee5w4r6OIiLyQPtFOvDmRJNWEUO5Eh7fVTKYCw==", "dfd75078-9754-4dc5-a398-82788914c90d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc12017-3526-443c-b7f9-2dfd9114c4e5", "AQAAAAIAAYagAAAAEH7cfEhDt+e55gSiLwbTBjHC3FBZ4+2fztlwxF2D1nqdDp0jRThpsmLfsoUjzpNClQ==", "a3404d5d-eaec-4eed-8ccb-9d64cb94812c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0fe3ed-d382-4a95-b724-0670db0016ed", "AQAAAAIAAYagAAAAEPLMu+oDX7KE82qv7GfW0OwC1t8YK7M6sTDTwM1eHscPU1nwj250osEOmfXSFdpa+A==", "894cb31f-1016-45cc-b3f6-0e166150bc71" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 18, 1, 45, 671, DateTimeKind.Local).AddTicks(8467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 15, 0, 40, 579, DateTimeKind.Local).AddTicks(3297));

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
        }
    }
}
