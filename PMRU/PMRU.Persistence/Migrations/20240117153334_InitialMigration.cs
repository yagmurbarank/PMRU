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
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), "c09f765e-b18e-4160-8a50-92f1cfed0e44", "SystemAdmin", "SYSTEMADMIN" },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), "9e6aaef6-32b6-46e0-9411-8fc576b5b7fe", "LocalAdmin", "LOCALADMIN" },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), "7b9cfe33-7050-4a98-b769-bcdaa7a9cf4b", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"), 0, "790814b3-4306-4e98-a36d-69ff8d06d00c", "localadmin@localhost.com", false, "Local Admin", false, null, "LOCALADMIN@LOCALHOST.COM", "LOCALADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHi+eJLVwC3lomaVD68lWUEgVNR6axYkMSJigJDvVjElJS3JKUvorzLdk2C+0VQYaA==", null, false, null, null, "101", "4e9d7f52-c907-4958-917a-ae66a978da1c", false, "localadmin@localhost.com" },
                    { new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"), 0, "8001291b-eb25-4b58-8880-04f8d4de3248", "doctor@localhost.com", false, "Doctor", false, null, "DOCTOR@LOCALHOST.COM", "DOCTOR@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKgqDEJ+0ZdxNyvtUQBD++d/K4XIScvW/z7buDfHiiRGftIssNH4Fnw8S7GxNHlYyw==", null, false, null, null, "102", "5d425bed-717a-4e52-a1b5-2fc1d05de1ff", false, "doctor@localhost.com" },
                    { new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"), 0, "6d0a00bd-3341-4938-af73-0dd37d2f12bd", "systemadmin@localhost.com", false, "System Admin", false, null, "SYSTEMADMIN@LOCALHOST.COM", "SYSTEMADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDaPct6UwUiMoxhed/OeFJklgIWn70aZQiLwXJsyqj5BxBwE7Y36SsMaL6QYRDJhgQ==", null, false, null, null, "100", "949f74ff-1266-4f89-a4e0-05d66450ce21", false, "systemadmin@localhost.com" }
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
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb") },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8") },
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09") }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, null, "aylin.gunes@email.com", "12345678901", true, false, 35, "Aylin", "Password", "5556123456", "102", "Güneş" },
                    { 2, null, "eren.akcay@email.com", "12345678923", true, false, 41, "Eren", "Password", "5556234567", "103", "Akçay" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2985), null, 4, "ahmet.yilmaz@email.com", "5555123456", true, false, 34, "Ahmet", "(555) 512-3456", 4, "100", "Yılmaz" },
                    { 2, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2987), null, 4, "ayse.kaya@email.com", "5555234567", true, false, 41, "Ayşe", "(555) 523-4567", 3, "101", "Kaya" },
                    { 3, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(2991), null, 3, "mehmet.celik@email.com", "5278149630", true, false, 35, "Mehmet", "(555) 534-5678", 5, "102", "Çelik" },
                    { 4, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3016), null, 4, "fatma.arslan@email.com", "5555456789", true, false, 71, "Fatma", "(555) 545-6789", 6, "103", "Arslan" },
                    { 5, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3018), null, 2, "ali.demir@email.com", "5555567890", true, false, 72, "Ali", "(555) 556-7890", 2, "104", "Demir" },
                    { 6, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3021), null, 5, "zeynep.yildiz@email.com", "5555678901", true, false, 35, "Zeynep", "(555) 567-8901", 14, "105", "Yıldız" },
                    { 7, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3023), null, 2, "can.aksoy@email.com", "5555789012", true, false, 41, "Can", "(555) 578-9012", 4, "106", "Aksoy" },
                    { 8, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3025), null, 6, "elif.ersoy@email.com", "5555890123", true, false, 34, "Elif", "(555) 589-0123", 8, "107", "Ersoy" },
                    { 9, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3028), null, 4, "burak.taskin@email.com", "5555901234", true, false, 72, "Burak", "(555) 590-1234", 7, "108", "Taşkın" },
                    { 10, 0, new DateTime(2024, 1, 17, 18, 33, 34, 233, DateTimeKind.Local).AddTicks(3030), null, 1, "deniz.akin@email.com", "5556012345", true, false, 71, "Deniz", "(555) 601-2345", 2, "109", "Akın" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentEndHour", "AppointmentStartHour", "CreatedDate", "DeletedDate", "Description", "DoctorID", "EmployeeID", "IsActive", "IsDeleted", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(6904), null, "Regular Checkup", 1, 1, true, false, null },
                    { 2, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(6932), null, "Regular Checkup", 2, 2, true, false, null }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreatedDate", "Date", "DeletedDate", "DoctorID", "EndTime", "IsActive", "IsDeleted", "LastModifiedDate", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8744), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 2, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8748), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 3, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8750), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) },
                    { 4, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8751), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 5, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8753), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 6, new DateTime(2024, 1, 17, 18, 33, 34, 232, DateTimeKind.Local).AddTicks(8754), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) }
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
