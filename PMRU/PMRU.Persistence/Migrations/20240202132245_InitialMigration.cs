using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMRU.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsLocationCenter = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availabilities_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AppointmentStartHour = table.Column<TimeOnly>(type: "time", nullable: false),
                    AppointmentEndHour = table.Column<TimeOnly>(type: "time", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), "b8189424-ccba-4f5d-87b7-bd74f1a0363d", "SystemAdmin", "SYSTEMADMIN" },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), "b379c5a0-6e68-429a-bcfd-7075c396f1c2", "LocalAdmin", "LOCALADMIN" },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), "c816d0b3-de61-4cfb-8436-0619fdea4ca9", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"), 0, "bd9466e4-fe1e-4cb5-9775-468ad7600a1e", "gulsum.aydin@email.com", false, "Gülsüm Aydın", false, null, "GULSUM.AYDIN@EMAIL.COM", "GULSUM.AYDIN@EMAIL.COM", "AQAAAAIAAYagAAAAEH2bvc9wkymhwuhi3LjrcvJNQv9cTWMs7ZnnHKsHneGjzTFjET3rAj2ROzyRPJLerQ==", null, false, null, null, "116", "b8d2b46e-3d3d-4f8c-b1b3-f98372e900aa", false, "gulsum.aydin@email.com" },
                    { new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"), 0, "7d8e7efe-53e8-465b-a75f-10902affe58d", "meryem.kuzey@email.com", false, "Meryem Kuzey", false, null, "MERYEM.KUZEY@EMAIL.COM", "MERYEM.KUZEY@EMAIL.COM", "AQAAAAIAAYagAAAAEDrQGTcEOvrUEAwIi4rYxkFHQ4rHRlOqmCj12aBiZFcsybHHy1j0kDQY/ZWv3udh/w==", null, false, null, null, "121", "8567420e-b85f-4b02-a7e6-146e61561284", false, "meryem.kuzey@email.com" },
                    { new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"), 0, "b4a2314a-32ab-4aed-a693-8f881158867f", "emre.yaman@email.com", false, "Emre Yaman", false, null, "EMRE.YAMAN@EMAIL.COM", "EMRE.YAMAN@EMAIL.COM", "AQAAAAIAAYagAAAAEPorNHo64/KNkMATdl0ZMoo+VMIUF6utzf+iufHF+UUHI4bmV4avqBbQpgJre0bhhg==", null, false, null, null, "117", "3927a500-7479-4cf9-8eb9-bc29de189e51", false, "emre.yaman@email.com" },
                    { new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"), 0, "64a2fc47-1d4a-49e3-b561-7e7fbc3146ce", "cem.yildirim@email.com", false, "Cem Yıldırım", false, null, "CEM.YILDIRIM@EMAIL.COM", "CEM.YILDIRIM@EMAIL.COM", "AQAAAAIAAYagAAAAEA0Kl1fizS0jbxPW0AmOY5p1HbiIOHCRVdSyl5PfAjcWX7l5mqyyxJjSsvfyQThvpA==", null, false, null, null, "113", "919c4c88-d165-4de2-81d4-30e6100864d2", false, "cem.yildirim@email.com" },
                    { new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"), 0, "8a7e987d-960b-464b-95a9-1c136e343acf", "mert.saglam@email.com", false, "Mert Sağlam", false, null, "MERT.SAGLAM@EMAIL.COM", "MERT.SAGLAM@EMAIL.COM", "AQAAAAIAAYagAAAAEB82EVBKuA4OzlyozPsBBb78jYUkpLQeaFi9DKYp54AjTRqTyXOLrxe1uHx/tTEohg==", null, false, null, null, "115", "d3e1c1af-eb34-4180-839e-0488718b8a4f", false, "mert.saglam@email.com" },
                    { new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"), 0, "20819e51-2a41-4430-8b87-4b7d1b7799e7", "eren.akcay@email.com", false, "Eren Akçay", false, null, "EREN.AKCAY@EMAIL.COM", "EREN.AKCAY@EMAIL.COM", "AQAAAAIAAYagAAAAEFFek6xznHyrM76KvGxgonkAMWK7AM8kcvSUMiGrtZ7eOF+eBXarZWxqvpIQb5pa4w==", null, false, null, null, "111", "62f17551-0a8f-4aa1-a7c0-729655f2e929", false, "eren.akcay@email.com" },
                    { new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"), 0, "b72160e9-8cca-4963-afad-f19a8a26abc1", "aylin.gunes@email.com", false, "Aylin Güneş", false, null, "AYLIN.GUNES@EMAIL.COM", "AYLIN.GUNES@EMAIL.COM", "AQAAAAIAAYagAAAAEOSd8BrUHhLoO47+J58MjAG2dpfmjy0ioTu3yyAjcrwH1SA484eHMxEorHuXy0XY6A==", null, false, null, null, "110", "065ac1dc-452a-4385-8f9d-9d7c37e44d40", false, "aylin.gunes@email.com" },
                    { new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"), 0, "07d6fc73-49a7-49f8-afbb-1483504ae4da", "ali.atabey@email.com", false, "Ali Atabey", false, null, "ALI.ATABEY@EMAIL.COM", "ALI.ATABEY@EMAIL.COM", "AQAAAAIAAYagAAAAEOSM4VwLucf3muOpdYouJiETTggJPLbjDiMJBfCMB53YZuhQosCDzZoK2PPPS2+PRQ==", null, false, null, null, "122", "181910b8-003e-40e7-bd3e-0087f68871d9", false, "ali.atabey@email.comm" },
                    { new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"), 0, "b354d9f7-2916-4e08-8ead-bbb6b4456eeb", "gulay.kaya@email.com", false, "Gülay Kaya", false, null, "GULAY.KAYA@EMAIL.COM", "GULAY.KAYA@EMAIL.COM", "AQAAAAIAAYagAAAAECX0mEuRzlc8tCvRi8ttWvHob0cYUGTT8+q+M3BlilNGL6/NSTOc/aviv3ypnmDxgw==", null, false, null, null, "112", "5105a4b1-5ea1-489a-9b68-0fc51d727007", false, "gulay.kaya@email.com" },
                    { new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"), 0, "d9bde632-1304-4106-b04b-25bb6cd49ef8", "elif.ersoy@email.com", false, "Elif Ersoy", false, null, "ELIF.ERSOY@EMAIL.COM", "ELIF.ERSOY@EMAIL.COM", "AQAAAAIAAYagAAAAEK4Ow1ARskueDExECZzaeDf9wZJjoTS38Itol2pRCpGSN9fDHemMC3IuKcD+mHiqGQ==", null, false, null, null, "107", "df898718-7c1e-47dd-9a83-84589b599f72", false, "elif.ersoy@email.com" },
                    { new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"), 0, "ee424114-fdbb-4b2b-a074-d529a579070c", "dilara.cetin@email.com", false, "Dilara Çetin", false, null, "DILARA.CETIN@EMAIL.COM", "DILARA.CETIN@EMAIL.COM", "AQAAAAIAAYagAAAAEEP3EHU2jOUDwW9lPjswd6BDMpymod62xc95lFX8dMH/y4LzfohRtDxLRVp5YaCzug==", null, false, null, null, "114", "608c9233-b751-44b3-87bf-5ab594eb65b2", false, "dilara.cetin@email.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DeletedDate", "DepartmentDescription", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, null, "Güvenlik", true, false },
                    { 2, null, "Üretim", true, false },
                    { 3, null, "Finans", true, false },
                    { 4, null, "İnsan Kaynakları", true, false },
                    { 5, null, "Satış Pazarlama", true, false },
                    { 6, null, "IT", true, false },
                    { 7, null, "Sağlık", true, false }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DeletedDate", "IsActive", "IsDeleted", "IsLocationCenter", "LocationDescription" },
                values: new object[,]
                {
                    { 34, null, true, false, true, "Genel Müdürlük" },
                    { 35, null, true, false, false, "İzmir" },
                    { 41, null, true, false, false, "İzmit" },
                    { 71, null, true, false, false, "Kırıkkale" },
                    { 72, null, true, false, false, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "DeletedDate", "IsActive", "IsDeleted", "PositionDescription" },
                values: new object[,]
                {
                    { 1, null, true, false, "Güvenlik Şefi" },
                    { 2, null, true, false, "Güvenlik Görevlisi" },
                    { 3, null, true, false, "Elektrik Mühendisi" },
                    { 4, null, true, false, "Makine Mühendisi" },
                    { 5, null, true, false, "Muhasebe Uzmanı" },
                    { 6, null, true, false, "Personel Uzmanı" },
                    { 7, null, true, false, "İnsan Kaynakları Uzmanı" },
                    { 8, null, true, false, "Yazılım Geliştirici" },
                    { 9, null, true, false, "Test Uzmanı" },
                    { 10, null, true, false, "Finans Uzmanı" },
                    { 11, null, true, false, "Pazarlama Uzmanı" },
                    { 12, null, true, false, "Doktor" },
                    { 13, null, true, false, "Hemşire" },
                    { 14, null, true, false, "Satış Temsilcisi" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68") },
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09") },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09") }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, null, "aylin.gunes@email.com", "12345678901", true, false, 35, "Aylin", "5556123456", "110", "Güneş" },
                    { 2, null, "eren.akcay@email.com", "12345678923", true, false, 41, "Eren", "5556234567", "111", "Akçay" },
                    { 3, null, "gulay.kaya@email.com", "12343458923", true, false, 72, "Gülay", "5556345678", "112", "Kaya" },
                    { 4, null, "gulsum.aydin@email.com", "12343458205", true, false, 34, "Gülsüm", "5556678901", "116", "Aydın" },
                    { 5, null, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "5556345358", "121", "Kuzey" },
                    { 6, null, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "5551862565", "122", "Atabey" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8869), null, 4, "ahmet.yilmaz@email.com", "5555123456", true, false, 34, "Ahmet", "(555) 512-3456", 4, "100", "Yılmaz" },
                    { 2, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8912), null, 4, "ayse.kaya@email.com", "5555234567", true, false, 41, "Ayşe", "(555) 523-4567", 3, "101", "Kaya" },
                    { 3, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8916), null, 3, "mehmet.celik@email.com", "5278149630", true, false, 35, "Mehmet", "(555) 534-5678", 5, "102", "Çelik" },
                    { 4, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8919), null, 4, "fatma.arslan@email.com", "5555456789", true, false, 71, "Fatma", "(555) 545-6789", 6, "103", "Arslan" },
                    { 5, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8922), null, 2, "ali.demir@email.com", "5555567890", true, false, 72, "Ali", "(555) 556-7890", 2, "104", "Demir" },
                    { 6, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8924), null, 5, "zeynep.yildiz@email.com", "5555678901", true, false, 35, "Zeynep", "(555) 567-8901", 14, "105", "Yıldız" },
                    { 7, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8927), null, 2, "can.aksoy@email.com", "5555789012", true, false, 41, "Can", "(555) 578-9012", 4, "106", "Aksoy" },
                    { 8, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8931), null, 6, "elif.ersoy@email.com", "5555890123", true, false, 34, "Elif", "(555) 589-0123", 8, "107", "Ersoy" },
                    { 9, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8933), null, 4, "burak.taskin@email.com", "5555901234", true, false, 72, "Burak", "(555) 590-1234", 7, "108", "Taşkın" },
                    { 10, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8943), null, 1, "deniz.akin@email.com", "5556012345", true, false, 71, "Deniz", "(555) 601-2345", 2, "109", "Akın" },
                    { 11, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8949), null, 7, "aylin.gunes@email.com", "5642597451", true, false, 35, "Aylin", "(555) 612-3456", 12, "110", "Güneş" },
                    { 12, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8959), null, 7, "eren.akcay@email.com", "5642517451", true, false, 41, "Eren", "(555) 623-4567", 12, "111", "Akçay" },
                    { 13, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8962), null, 7, "gulay.kaya@email.com", "3462517451", true, false, 72, "Gülay", "(555) 634-5678", 12, "112", "Kaya" },
                    { 14, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8965), null, 7, "cem.yildirim@email.com", "3434517451", true, false, 35, "Cem", "(555) 645-6789", 13, "113", "Yıldırım" },
                    { 15, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8968), null, 7, "dilara.cetin@email.com", "3434546751", true, false, 72, "Dilara", "(555) 656-7890", 13, "114", "Çetin" },
                    { 16, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8971), null, 7, "mert.saglam@email.com", "3432209751", true, false, 41, "Mert", "(535) 896-4526", 13, "115", "Sağlam" },
                    { 17, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8973), null, 7, "gulsum.aydin@email.com", "3432906751", true, false, 34, "Gülsüm", "(555) 667-8901", 12, "116", "Aydın" },
                    { 18, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8976), null, 7, "emre.yaman@email.com", "3850906751", true, false, 34, "Emre", "(555) 678-9012", 13, "117", "Yaman" },
                    { 19, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8978), null, 5, "selin.erdogan@email.com", "3850915851", true, false, 41, "Selin", "(555) 689-0123", 11, "118", "Erdoğan" },
                    { 20, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8982), null, 3, "onur.akbas@email.com", "3850926751", true, false, 35, "Onur", "(555) 690-1234", 10, "119", "Akbaş" },
                    { 21, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8984), null, 6, "melis.yilmaz@email.com", "3880226751", true, false, 34, "Melis", "(555) 701-2345", 9, "120", "Yılmaz" },
                    { 22, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8987), null, 7, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "(555) 634-5358", 12, "121", "Kuzey" },
                    { 23, 0, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(8990), null, 7, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "(555) 186-2565", 12, "122", "Atabey" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentEndHour", "AppointmentStartHour", "CreatedDate", "DeletedDate", "Description", "DoctorID", "EmployeeID", "IsActive", "IsDeleted", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(133), null, "Regular Checkup", 1, 1, true, false, null },
                    { 2, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(163), null, "Regular Checkup", 2, 2, true, false, null }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreatedDate", "Date", "DeletedDate", "DoctorID", "EndTime", "IsActive", "IsDeleted", "LastModifiedDate", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2743), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 2, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2751), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 3, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2753), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) },
                    { 4, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2754), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 5, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2756), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 6, new DateTime(2024, 2, 2, 16, 22, 43, 792, DateTimeKind.Local).AddTicks(2757), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EmployeeID",
                table: "Appointments",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_DoctorID",
                table: "Availabilities",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_LocationID",
                table: "Doctors",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LocationID",
                table: "Employees",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionID",
                table: "Employees",
                column: "PositionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
