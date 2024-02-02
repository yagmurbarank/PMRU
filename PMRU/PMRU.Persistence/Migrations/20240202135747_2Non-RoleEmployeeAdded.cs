using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _2NonRoleEmployeeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 531, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 531, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "be15927c-5030-45cd-aee8-6e883baa50f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "894a79dc-56f8-489e-afeb-ed638c772369");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "f760b9c1-94f5-4938-b023-51b79ed004a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfae36f0-2107-48f5-af12-070914e6965b", "AQAAAAIAAYagAAAAEPFq4XWQni0jbskmjtyhKiJIA0tJVfLYNRD1JMdxbsP2MAXBVpu4lmj8PS80f3xpEg==", "d923b5e6-a4fc-418d-bea4-1fb86175b98c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57989825-7db7-4aec-9c97-72605ab91816", "AQAAAAIAAYagAAAAEJSodZy9qiJEy9ho93DFC9N31JBanUiLTTq5Gu3Cdtcllclq2sJ14CBmV0Uxz3aHwQ==", "e1e3ca98-195d-4935-b913-7af40f611373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b2c764-70f6-4018-af09-6d9fa97fcc25", "AQAAAAIAAYagAAAAEBaJPjPiAF5/kvApAoL8s+mQYNIidmB5diLCBUmq65ufeCJe/Pk2dwFn7gJpuF+R9g==", "8178191f-0064-46d4-a067-87fdb21344a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2564b0c5-1a6d-40fa-85f3-53ca8e1288e9", "AQAAAAIAAYagAAAAEGccGr7PXpPUa6P8S+WORINcUSzt76sNLeDltN9texnncpaiTe5+7sSCXf18/CPTQQ==", "97e4da42-ca66-41b6-b53c-79c5f3d52168" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bebfbda-026a-48a7-ac45-c3f21b690076", "AQAAAAIAAYagAAAAEHOydnHigNR/N4yzM/nL5UMkIjl03bx+3mFoLUzAZglI8iN3vwvLqyQp2wQVCf+ksw==", "b4743dc1-7d28-48d0-8a5e-898000250bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d674b976-7249-4a38-b6e5-48f3c0294b66", "AQAAAAIAAYagAAAAEHUNTevXnZ2nr8m4gXHJP26kQv0SJp9WIeRpKih6sQf5BtxtqkrPvIi4welI6Ofw7g==", "a96065e0-bda9-4abd-83c5-7658545ac1d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78efb475-9a17-4649-b057-5647c50bfe0c", "AQAAAAIAAYagAAAAEKuT95ieHnh2pm0QH2e4NySu4M0CjIDYkPT6lD5+4yGiQ4++jMD0Cm0gj2T6W7F02A==", "f13dd4d8-2d91-4ae5-a5ee-3ce1fba32441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "defc4dc1-022b-4cb0-8942-c4b38bae5dac", "AQAAAAIAAYagAAAAENJGp2EDmDyLZByoH7CsfA/oLnLiflCvFOy1cM83W/VSRFJc1otrw5WuUi/kBtOLNA==", "cc7abfc6-f7ad-436c-8932-c90dd759588c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa559dfe-d73f-4d88-93c6-d2f9db101944", "AQAAAAIAAYagAAAAEIT+ROQK3druxIRiNjoyzre9c9XQzVpn8uPG7WTGZ9E5x+EeJLpZOJcI9xzsu16l7g==", "df97874a-4b77-43fb-9d21-22440c343e88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5920b06d-14c7-4e4a-8257-eb6107be4708", "AQAAAAIAAYagAAAAEJOABVb6dBIAslvniPbx5MDQP2ihHfEELE2oUl7UEqORcFWSnEHqnD5Q+xpWEfKs7A==", "3a0f6c40-5a5d-4fc0-8ffe-0f7a9d0ad8a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7b3b248-ddeb-4de3-b55b-87f7e8d6af88", "AQAAAAIAAYagAAAAEHEA0nsAB3Jdv0HSIeaHL6OzaEJKj9CbCxqXMxEZk5Px5kU11ONg86nR+q3UlXHoTg==", "fd9c11b9-8065-45ff-bd59-ff5e6ca66877" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 532, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 24, 0, new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(6000), null, 7, "melih.dogru@email.com", "4571927923", true, false, 71, "Melih", "(555) 158-6945", 12, "123", "Doğru" },
                    { 25, 0, new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(6002), null, 7, "zehra.firinci@email.com", "8271927909", true, false, 34, "Zehra", "(555) 136-4785", 13, "124", "Fırıncı" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "b8189424-ccba-4f5d-87b7-bd74f1a0363d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "b379c5a0-6e68-429a-bcfd-7075c396f1c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "c816d0b3-de61-4cfb-8436-0619fdea4ca9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd9466e4-fe1e-4cb5-9775-468ad7600a1e", "AQAAAAIAAYagAAAAEH2bvc9wkymhwuhi3LjrcvJNQv9cTWMs7ZnnHKsHneGjzTFjET3rAj2ROzyRPJLerQ==", "b8d2b46e-3d3d-4f8c-b1b3-f98372e900aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8e7efe-53e8-465b-a75f-10902affe58d", "AQAAAAIAAYagAAAAEDrQGTcEOvrUEAwIi4rYxkFHQ4rHRlOqmCj12aBiZFcsybHHy1j0kDQY/ZWv3udh/w==", "8567420e-b85f-4b02-a7e6-146e61561284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a2314a-32ab-4aed-a693-8f881158867f", "AQAAAAIAAYagAAAAEPorNHo64/KNkMATdl0ZMoo+VMIUF6utzf+iufHF+UUHI4bmV4avqBbQpgJre0bhhg==", "3927a500-7479-4cf9-8eb9-bc29de189e51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a2fc47-1d4a-49e3-b561-7e7fbc3146ce", "AQAAAAIAAYagAAAAEA0Kl1fizS0jbxPW0AmOY5p1HbiIOHCRVdSyl5PfAjcWX7l5mqyyxJjSsvfyQThvpA==", "919c4c88-d165-4de2-81d4-30e6100864d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7e987d-960b-464b-95a9-1c136e343acf", "AQAAAAIAAYagAAAAEB82EVBKuA4OzlyozPsBBb78jYUkpLQeaFi9DKYp54AjTRqTyXOLrxe1uHx/tTEohg==", "d3e1c1af-eb34-4180-839e-0488718b8a4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20819e51-2a41-4430-8b87-4b7d1b7799e7", "AQAAAAIAAYagAAAAEFFek6xznHyrM76KvGxgonkAMWK7AM8kcvSUMiGrtZ7eOF+eBXarZWxqvpIQb5pa4w==", "62f17551-0a8f-4aa1-a7c0-729655f2e929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b72160e9-8cca-4963-afad-f19a8a26abc1", "AQAAAAIAAYagAAAAEOSd8BrUHhLoO47+J58MjAG2dpfmjy0ioTu3yyAjcrwH1SA484eHMxEorHuXy0XY6A==", "065ac1dc-452a-4385-8f9d-9d7c37e44d40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07d6fc73-49a7-49f8-afbb-1483504ae4da", "AQAAAAIAAYagAAAAEOSM4VwLucf3muOpdYouJiETTggJPLbjDiMJBfCMB53YZuhQosCDzZoK2PPPS2+PRQ==", "181910b8-003e-40e7-bd3e-0087f68871d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b354d9f7-2916-4e08-8ead-bbb6b4456eeb", "AQAAAAIAAYagAAAAECX0mEuRzlc8tCvRi8ttWvHob0cYUGTT8+q+M3BlilNGL6/NSTOc/aviv3ypnmDxgw==", "5105a4b1-5ea1-489a-9b68-0fc51d727007" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9bde632-1304-4106-b04b-25bb6cd49ef8", "AQAAAAIAAYagAAAAEK4Ow1ARskueDExECZzaeDf9wZJjoTS38Itol2pRCpGSN9fDHemMC3IuKcD+mHiqGQ==", "df898718-7c1e-47dd-9a83-84589b599f72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee424114-fdbb-4b2b-a074-d529a579070c", "AQAAAAIAAYagAAAAEEP3EHU2jOUDwW9lPjswd6BDMpymod62xc95lFX8dMH/y4LzfohRtDxLRVp5YaCzug==", "608c9233-b751-44b3-87bf-5ab594eb65b2" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8990));
        }
    }
}
