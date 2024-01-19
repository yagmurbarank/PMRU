using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MultipleDoctorsInSameLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01b33042-952a-4636-8d15-682447de311a"),
                column: "ConcurrencyStamp",
                value: "dcdd12af-3e7e-4ae5-879e-ebe7df277355");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"),
                column: "ConcurrencyStamp",
                value: "a599d9b6-c5d3-445e-a28b-035b86ceddc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"),
                column: "ConcurrencyStamp",
                value: "07149a21-2545-40b8-a2d4-61e4dc6fb6d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "761fcf7e-d88d-4f58-97e6-9bc0ecc84e84", "AQAAAAIAAYagAAAAELUKB9aRQLmfQPguVobwC7hTgs+1In39JagSg2obRyvEbMXUSAp+n5Zaypf1HzenWw==", "a50b652e-3382-4896-974c-2cfb4d984407" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dd7612-44c9-415e-a234-631bc92c557d", "AQAAAAIAAYagAAAAECzQnzBSjkHs21PzzjQiZ8t7keKEfCil8ZJBbFakPbc2DMCGHeQ85CWXkD9HvDjHeQ==", "59b7fc55-905e-4fe6-9be3-00cf5a4aa65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a5db2f7-d777-4914-add6-e0a0cada38ec", "AQAAAAIAAYagAAAAEFmCwQdQMoEMQG2jpCVLSlxxEPavTZVbeY4IsMdUYkT970dvJXcnVEvXGRBKw5WprQ==", "e5174d56-223d-4496-9414-c36096efb30f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3de5aa-80ee-41f5-84bb-9b151d6f3593", "AQAAAAIAAYagAAAAEKt0KcMn2CVeTEv7j1j4Hx3RVCIHh/KnH+Uv+S0YjTVAjUYssHaR0v+2ohJ7ohkYXw==", "57e2e56c-6e6b-4835-be3d-2604932571a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "319d9698-ee44-4046-b6bd-47c14260df87", "AQAAAAIAAYagAAAAEGzaUbJwhn3+W+tgshDDS3aveZP7sR3hx6FTVpT6tfqlcUVH5MLdTypjUS3fzZHzkg==", "279ff61b-efe0-4932-a99e-2ff372db83b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7753ee68-cb02-4ee5-bd78-e9fa104d8601", "AQAAAAIAAYagAAAAENO9sTwZIo3HvsoWd4kUauvqeXOOPt0vTRV//B1OhBBCbbxrehUW6PabyYM8Um2rLw==", "35391354-0b5d-4806-97bc-e935dbfcbac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8816f7d-2a8a-4d9f-8fa1-48b78190a142", "AQAAAAIAAYagAAAAELZDeEysCdsqhTwOv3Fkv2B8F9mnpxDeCZiCR50kSKmlx0C9Fm7O50TvVT18wbzV3A==", "1ca13596-79bd-4da6-b76d-a957a0c5144a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ac1e60c-7ae6-4533-ba2b-0666c0294418", "AQAAAAIAAYagAAAAEFFLAA4q0Va5JzVFeiUgDZylJ8qoqvWju/bsEv/V91wc5p9rFn+X7OS1qCgR/UlY/A==", "7e68d724-4ee6-4c33-b367-846a69075f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839adf3e-bdbb-44f8-b761-39ab8a4805c1", "AQAAAAIAAYagAAAAEOMtvVkWf7kv4JQeLgnOKZNL9Wiy5TCs2iE3RmgYkcjmdBxekWf2IxNxtugeph/NZg==", "eb43a5f0-b1ac-4b64-ab4c-59c1e022f21b" });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 180, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 5, null, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "Password", "5556345358", "121", "Kuzey" },
                    { 6, null, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "Password", "5551862565", "122", "Atabey" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 22, 0, new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2210), null, 7, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "(555) 634-5358", 12, "121", "Kuzey" },
                    { 23, 0, new DateTime(2024, 1, 19, 17, 46, 45, 182, DateTimeKind.Local).AddTicks(2213), null, 7, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "(555) 186-2565", 12, "122", "Atabey" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

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
    }
}
