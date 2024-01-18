using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserinfosCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 8, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 8, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "09c46b92-ca72-4832-b88c-b5dffd20f492");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "2c0d0dbc-5024-42ac-85ac-96a64d90adce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "1a3ef764-0613-4eec-8f10-872a46f17125");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20df7317-354b-4d26-9131-da341c0d66c6", "AQAAAAIAAYagAAAAEMmL1KygtADO3O4kH79zg8XHpMHjhWzgRAQcnIgUr5cDL/Q9L9Cr0wxyD0igtCMQrw==", "bbbfe8ed-3818-4c5e-93d4-75d24f86f89b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeb3c305-8e90-4c7a-8576-c6230abcf8b2", "AQAAAAIAAYagAAAAEB6HTq3ty1TFE39RzzHWTpk6NgbuiK1bM4AmQf2aGIawSpynoHwAEYQgMh3S8JSkhw==", "1ded0ad3-6021-4d0f-8d04-295f74d133a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a2c0e16-a2d6-4002-9397-601b85681007", "AQAAAAIAAYagAAAAED0ks5HDOI+zikKRKocRmeztXkafZaHPfaIg2a7/0lZejHTzktsnAWa7lSr0B5/tHA==", "f92e39c9-7c15-4017-a551-ab03897c874c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd07923-45ef-43d2-9b70-eb457ac01c4e", "AQAAAAIAAYagAAAAEO6J8O1/uuPiY/6OYkpdRdFguJlJTzijzcvxUkLM4El19m4DpeyTJaUYARZt0oSrjQ==", "29a56412-8ef7-4eff-b6da-70328fe99cf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a919b094-851f-477e-9e5e-73bb5d26307f", "AQAAAAIAAYagAAAAENP3TcGN6h/NtC4u37i2igV19KQcqQkzJXNUOT3GrecZQk1hcVb9jbwhVoX/Q4peUA==", "cbbdfef7-ecf5-4172-a0f2-ef5e8fce9620" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef2d0b3d-b3ea-4ae2-8475-2311db970d42", "AQAAAAIAAYagAAAAEHXZycp7CbIP+eXo3xLgBFjvrLGiCVeOA6k0mW/c51KOlLv5PEppoXb3KP3tERRv1A==", "fe8a6dba-c006-4673-bb7f-8a5a29bf1e32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6de5cb0-29bb-4f00-87e3-6e382a954182", "AQAAAAIAAYagAAAAEBxa9R+S68WkkbA/2fwg1VRBfkwjOudfM2J/F652XGf5zKSnNXZN7S/aPYOI4ZjKHA==", "65dbc660-3d9d-4238-8e07-c24e555ef3a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d20fe4f5-938b-4683-9429-6e1e8cb3b8ae", "AQAAAAIAAYagAAAAEP94Nj+IA89WwfyeRKd4n3x9Cl5Kmv5ciRO3qGI6ur9mnKKABSixuEJBInBVapoMvA==", "f01c6b8e-7171-45de-abf4-c9dbe01e2a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4b23ca9-dec9-48e4-8028-0d9545cd4f84", "AQAAAAIAAYagAAAAEE12Cg+g0vxKzIgAY7Ch6Sd/1vPfMWOs32Q0JgtsWX+S1iwJzXa/eGfwx+wdSM9Fjw==", "07eb1ba8-377e-459c-be14-c965ac7960ff" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 9, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 23, 56, 38, 10, DateTimeKind.Local).AddTicks(6752));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f") });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 724, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 724, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "44952f0b-d8f2-42ad-b1ca-fe5d5d8377c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "62256794-887b-4e60-9096-d68b93270bcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "97e10a8e-6724-4c92-81a1-b12737fdf95c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34db62f3-4cf3-45bd-bb6e-77280b1cc7fd", "AQAAAAIAAYagAAAAEHX9JwpT8obTBW9/ErHy/OqTbM95+iq3H1ZUUPFWQuiyt2HZ11uSsDjw8Cf/kFxsBA==", "709162aa-b49a-485e-a1e0-11253b11960a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0097b68b-0dcb-42ce-a606-a8ff13fd1b3d", "AQAAAAIAAYagAAAAEH8sWsGH/H8h9caYgpueWw/A19r31CEMCSQh1A7YGByQ95lel8f1uwZ80dTesJGVAg==", "780450fa-f292-41c5-8d74-33f356fee6e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ea0bc9-47b2-4fc1-a1b9-2fd0351997a4", "AQAAAAIAAYagAAAAEOxRw7ELs3jwPGxYlbYpPzUJ6TJt5CuD9JDdWYNymZnz82kie7WoY6O08FZouLioLw==", "fbd9004a-778f-4fb1-a9b7-6d391c91cc3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf44bf9d-8ef2-409d-9746-2cbf669f75ba", "AQAAAAIAAYagAAAAEFmfMhNgRek1osyNJtGyYjPB2tRAxn64sFnGgkC7SSgv55sL9fpYjuQfIG36Y9RB5Q==", "fd039f34-a09b-4e2c-a5d5-071aa2b7a509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c46c30ae-318c-4d41-9ede-3e4d33cdef2b", "AQAAAAIAAYagAAAAEKR5jjkz8eS/dPaIp2Ys/TVdUTDgUD4ASzVGZdeIEgDLLL3+NMg24bBt+ERLAKBb7Q==", "56583fce-0dad-48f6-90fd-38f425f8ad13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a699c491-1bb9-4da1-9e04-640a1effa8fd", "AQAAAAIAAYagAAAAEMI45Ew1KiZyZy1wjRHKZQNivI6kxg05MKbZHtunC+8fF9QKiJwXsWySE/otzKO5xQ==", "6c69a3f7-4576-447f-b33f-57e9f4ff4f3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39245f5-2006-4647-9a84-57a3f2412c1b", "AQAAAAIAAYagAAAAECaMJAKaS77/drGFOwr95LTtrqacX6tKzsBkzh+JB6kerWzEZgQNBmv2CQiBpsOpbw==", "4c816c31-b0a3-473e-a111-b3181eddea6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32ada948-5e3a-49fd-b412-2de429b8554f", "AQAAAAIAAYagAAAAEBQorwkUiis6T4jB0x7XCadqo2vzstOm/7xe0pTFYy37wu7WhKWYIv4OSbucGzFayg==", "4233b8f8-b68a-4ead-985c-71d993beac52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55711f4d-866c-4637-8b40-79a5a5d2461a", "AQAAAAIAAYagAAAAEIT/IS7/pz3NZ6guY/O3UvJC7EbyHdsGZ906x/VX8gtqD/R35gcfxqyyCLeC4zKhSA==", "fc874370-b427-46d1-8322-0ce28f035e7a" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 725, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 18, 19, 29, 45, 726, DateTimeKind.Local).AddTicks(7461));
        }
    }
}
