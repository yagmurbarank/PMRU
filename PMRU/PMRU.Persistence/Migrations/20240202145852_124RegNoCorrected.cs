using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _124RegNoCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 980, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 980, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "f9da22a2-c18b-46d7-82b8-e66a40b4782d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "395c57e2-5dee-4bc2-be7f-ab0247fc1047");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "036c2f19-5688-4499-b472-39b4e73c0bea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1231ba11-7112-45d2-9366-83f8b023ca80", "AQAAAAIAAYagAAAAEK+xx8XgmpwgPYofIPzfwg+6pNMGaoI9w10wR1r61/mOhJOUomSynvqRMlPyniESqw==", "eb9d9c3d-3762-476f-8ae0-23451ac91f79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "472f4dfa-eb53-4ec4-a159-322ee3dd1c61", "AQAAAAIAAYagAAAAEFkS9Xl/GtebcjsX4WpnU+5wIuL97+x+iWob/iXkuHwULpl8vmKkH88s7Zv0L9trMA==", "f1e22704-f451-419b-9daf-fcad2c8f635c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65d85cf-c4f5-44d7-809e-27e9766404bb", "AQAAAAIAAYagAAAAEAohl/sBE5AUew/IBzZgvDVoLjhGzH91ub62MgOZLPCiOT9Z5y9rW7Z5YgqMpJWuXQ==", "f78bf507-dd92-4e8a-b65d-a179ecd6feec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5362762-ddb2-4a54-9b2d-09e614951f49", "AQAAAAIAAYagAAAAEBBLM1MjbC5pUWpORpPglilo/mrM1FA0niENMNeUjTsyvR6sT5UbunpqaG6TpF6v1w==", "fac4338c-d400-4e0c-8e3e-20a5bb9b2ec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e4b613-1205-4a37-b680-ffff3c354b6d", "AQAAAAIAAYagAAAAENML7kEYMAN69cfVsnRcMGN8r936KeKLa8gmy5VIiXNn4MjDlBrX2mo9NiI0zHwZYw==", "da54a475-060c-4ee9-a6e1-791eac8df97d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6c426a-0654-44fe-802e-4ead7faea645", "AQAAAAIAAYagAAAAEEGjlUBXxn0Wxbf0H4F0tNWLhiWqcd9tLHJ+myzJRTf9MentIa/+d8+w6Zc/RmC1MA==", "fca74e0e-974e-4134-a9a4-9599d5a48f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e62e994-ef96-4dbc-a03c-fdb56b29d69e", "AQAAAAIAAYagAAAAEFE+eIeA/KbANM79YRRTzkrT/xK3wwWwGrGQQT38zXRwdWvfUehizH3TCJ2HxsI35w==", "7a7c2630-d4f7-4ebe-b1f6-450d701867b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f1c93b-9d08-466e-8120-2639362e3e68", "AQAAAAIAAYagAAAAENt4Eqphjtxo/fwIXSUqb7ornSw2OpEg97tjK+eJQOnKJ3sX9DST0UDkTL1g03BCxQ==", "0567fb73-208f-46c2-ae4c-4c923511d5ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "098ec21e-31a0-4196-9177-722ee67f7dea", "AQAAAAIAAYagAAAAEPafbf1keiCBMHOjXJMqBmSz7XG/S/hviQCS6coAO7OLLArp0YJjl5qj7cKuEQlS/A==", "3e294e20-a90e-46bf-9992-4ba1c8f40491" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd72d02-993f-4a75-85bf-9e41e4fb3496", "AQAAAAIAAYagAAAAEI57oFZQGEkK9dcniThawNE/CXscpCKavIYZXKwswAuT07kV0Jj8uzRySWRhq9DMqg==", "8c65717f-ee30-4277-8575-63b205a9f31f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33ac459-b6d2-416b-8467-87f52a25e8cd", "AQAAAAIAAYagAAAAECiHGC/1R2+x9HqxbYl32J5sQypaQjTnGoBcr6jgfffzicSS47Q6WoioCAIldbaaAg==", "09a6119b-e0b2-4b3e-b6ef-e5075b4b8eb5" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 981, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LocationID" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 58, 49, 982, DateTimeKind.Local).AddTicks(5335), 71 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "LocationID" },
                values: new object[] { new DateTime(2024, 2, 2, 16, 57, 45, 533, DateTimeKind.Local).AddTicks(6002), 34 });
        }
    }
}
