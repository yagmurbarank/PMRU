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
                    { new Guid("01b33042-952a-4636-8d15-682447de311a"), "a9882d37-64b1-42ea-b2a0-4a3a145c0b31", "SystemAdmin", "SYSTEMADMIN" },
                    { new Guid("b56d0892-1daa-4b5d-a6e0-381a250daea1"), "5e228b2d-03a9-4e6b-ad5f-62872e75cd31", "LocalAdmin", "LOCALADMIN" },
                    { new Guid("e3a11d19-3f92-463a-a80d-38228fa18746"), "6738590f-15fa-4c78-b631-623273836056", "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0e7b95a1-9b14-4c87-af3d-1d2f6b8aefc3"), 0, "9d4e5fd8-1c3e-4247-bbd9-33b3a0c1663a", "gulsum.aydin@email.com", false, "Gülsüm Aydın", false, null, "GULSUM.AYDIN@EMAIL.COM", "GULSUM.AYDIN@EMAIL.COM", "AQAAAAIAAYagAAAAEI02sqOnMLvVF2HTmKVKgNBXGVMMxw6Sb5eceULJaMIuNoU47xlEntx5ZEwzm6Jucg==", null, false, null, null, "116", "0ebccc17-95ba-4581-8882-e0388c8324cf", false, "gulsum.aydin@email.com" },
                    { new Guid("2b9d163d-cdd1-4b2c-b62e-ec59a6b300fb"), 0, "3667f8b3-6b59-4b5a-8d01-60194bba34bc", "meryem.kuzey@email.com", false, "Meryem Kuzey", false, null, "MERYEM.KUZEY@EMAIL.COM", "MERYEM.KUZEY@EMAIL.COM", "AQAAAAIAAYagAAAAEMh7IMuMIWWcuMYvQSCwXw16j+x2KK3MoSgK70C/EnXq1zg5TpUC2eyNNcHWmlPUEw==", null, false, null, null, "121", "5321620b-b1cc-48af-8e73-3ea399ca18b3", false, "meryem.kuzey@email.com" },
                    { new Guid("3a7f9b68-21d5-4f8c-b2a7-9c0e1f5d2a91"), 0, "c082e466-0e6d-4132-8d8e-1a3dcebd2724", "emre.yaman@email.com", false, "Emre Yaman", false, null, "EMRE.YAMAN@EMAIL.COM", "EMRE.YAMAN@EMAIL.COM", "AQAAAAIAAYagAAAAEEw3RtgwowdcQxFj0RSZw1nRloOzKwkduTZIKRqHqbJC4jCWUBtZBZGKFW0bQ7NOmg==", null, false, null, null, "117", "18e06429-8702-4080-bddf-55d1b3576ca0", false, "emre.yaman@email.com" },
                    { new Guid("79a21042-ac37-43dc-b246-e1a2c9645afb"), 0, "e9ddadba-953d-45a1-bfb4-9229775e0b42", "cem.yildirim@email.com", false, "Cem Yıldırım", false, null, "CEM.YILDIRIM@EMAIL.COM", "CEM.YILDIRIM@EMAIL.COM", "AQAAAAIAAYagAAAAEOwIQDb97bhuyoLtgPzcX59eXzmTHyg4pHoNA+1tEmGHtTScqiDSrhJ+9HF9CywHuA==", null, false, null, null, "113", "2854e473-479f-4d7d-b4a2-ba227a9c63fd", false, "cem.yildirim@email.com" },
                    { new Guid("a2b4f813-72c9-4a6e-9d7b-1f8c3d2e5a0f"), 0, "3e785974-81da-4703-adaf-322ee2eedb7d", "mert.saglam@email.com", false, "Mert Sağlam", false, null, "MERT.SAGLAM@EMAIL.COM", "MERT.SAGLAM@EMAIL.COM", "AQAAAAIAAYagAAAAENDgYpiIfeu5MlO8L9tU1AHT6NrkMXSlopW3leEkEeFIZUiwL+dMWbeujowvz1b20A==", null, false, null, null, "115", "d6ca6a77-a905-4cf1-8e3c-0a695f81b2cd", false, "mert.saglam@email.com" },
                    { new Guid("a3b9e2f7-5c1d-4a88-9f3b-7e6c4d2a1b11"), 0, "ed821b9f-dade-4638-8229-1ac1b5715a8f", "eren.akcay@email.com", false, "Eren Akçay", false, null, "EREN.AKCAY@EMAIL.COM", "EREN.AKCAY@EMAIL.COM", "AQAAAAIAAYagAAAAEKPSMbN5sWfAfyk37LUFlgA8RvOVPXc8+z9ZZmpEu4gm8Q44PklVclng/CBbsH6Qkg==", null, false, null, null, "111", "c4dd69be-e1c9-467b-9168-481a14c1242c", false, "eren.akcay@email.com" },
                    { new Guid("a76eb5c4-eebf-47ec-a274-ca7971bfa4e8"), 0, "028ce5cf-9853-4bcf-afcd-53fe310931a7", "aylin.gunes@email.com", false, "Aylin Güneş", false, null, "AYLIN.GUNES@EMAIL.COM", "AYLIN.GUNES@EMAIL.COM", "AQAAAAIAAYagAAAAEJ5hqu1q/TOuat7QuR+FpqMyKGUOEutRw1o4x9R8n5O1f5gJuIEI4MQmgGT0pxFlDg==", null, false, null, null, "110", "c20f829c-d00c-4afd-a08f-970ba27fd6d0", false, "aylin.gunes@email.com" },
                    { new Guid("b4f91e33-68d1-4aee-b254-d8a53631b23a"), 0, "c0d13827-88fe-4a9b-b19b-57f7fe234f65", "ali.atabey@email.com", false, "Ali Atabey", false, null, "ALI.ATABEY@EMAIL.COM", "ALI.ATABEY@EMAIL.COM", "AQAAAAIAAYagAAAAEA/sOgvGtlsEpitjxKLKS3cE9S+sS11iKxEm4jXMce5ppLmg7Hv9iYvd2twuWmxFBQ==", null, false, null, null, "122", "018650c3-7255-4ade-bd3d-dde24efe7a27", false, "ali.atabey@email.comm" },
                    { new Guid("e2f8d174-4b7a-4c91-b9f2-8dc3a1c45b68"), 0, "4c6009ed-c6ba-440c-b027-9b5687b99c82", "gulay.kaya@email.com", false, "Gülay Kaya", false, null, "GULAY.KAYA@EMAIL.COM", "GULAY.KAYA@EMAIL.COM", "AQAAAAIAAYagAAAAEHf2Jk04oHjimSjVejvEfEln9wYOcY2FKTAB9/t9ZTm09GSbDLlKS7hPumIg1D/SlA==", null, false, null, null, "112", "cf07fde1-e8e9-45cb-accd-19918430b47d", false, "gulay.kaya@email.com" },
                    { new Guid("faad6812-0f8e-4342-8738-6dcd5e8ecc09"), 0, "793dbbc5-4100-4a7a-901b-c052bd9f2499", "elif.ersoy@email.com", false, "Elif Ersoy", false, null, "ELIF.ERSOY@EMAIL.COM", "ELIF.ERSOY@EMAIL.COM", "AQAAAAIAAYagAAAAEAZVdEtYudeagrKoPg4CmvKUI3nzgbWqr/j5Y0YMEDlQFkyqQV4/fXPWh9Aa5uHMkg==", null, false, null, null, "107", "eb931d41-12fa-4e35-a524-278eac9edfef", false, "elif.ersoy@email.com" },
                    { new Guid("faad6812-0f8e-4342-aabb-6dcd5e8ecc09"), 0, "d2e94158-fea2-4794-b865-49c2932983ff", "dilara.cetin@email.com", false, "Dilara Çetin", false, null, "DILARA.CETIN@EMAIL.COM", "DILARA.CETIN@EMAIL.COM", "AQAAAAIAAYagAAAAEDZu4IbfVAWGIDBewZzrbvSEN47pN3yrrYOOr/H0QwjuBtKcMQmnm7V2PQfrwraevg==", null, false, null, null, "114", "a0d3879a-d0a5-4cf9-b58c-8e2a110f51da", false, "dilara.cetin@email.com" }
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
                columns: new[] { "Id", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, null, "aylin.gunes@email.com", "12345678901", true, false, 35, "Aylin", "Password", "5556123456", "110", "Güneş" },
                    { 2, null, "eren.akcay@email.com", "12345678923", true, false, 41, "Eren", "Password", "5556234567", "111", "Akçay" },
                    { 3, null, "gulay.kaya@email.com", "12343458923", true, false, 72, "Gülay", "Password", "5556345678", "112", "Kaya" },
                    { 4, null, "gulsum.aydin@email.com", "12343458205", true, false, 34, "Gülsüm", "Password", "5556678901", "116", "Aydın" },
                    { 5, null, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "Password", "5556345358", "121", "Kuzey" },
                    { 6, null, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "Password", "5551862565", "122", "Atabey" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5044), null, 4, "ahmet.yilmaz@email.com", "5555123456", true, false, 34, "Ahmet", "(555) 512-3456", 4, "100", "Yılmaz" },
                    { 2, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5055), null, 4, "ayse.kaya@email.com", "5555234567", true, false, 41, "Ayşe", "(555) 523-4567", 3, "101", "Kaya" },
                    { 3, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5057), null, 3, "mehmet.celik@email.com", "5278149630", true, false, 35, "Mehmet", "(555) 534-5678", 5, "102", "Çelik" },
                    { 4, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5060), null, 4, "fatma.arslan@email.com", "5555456789", true, false, 71, "Fatma", "(555) 545-6789", 6, "103", "Arslan" },
                    { 5, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5427), null, 2, "ali.demir@email.com", "5555567890", true, false, 72, "Ali", "(555) 556-7890", 2, "104", "Demir" },
                    { 6, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5431), null, 5, "zeynep.yildiz@email.com", "5555678901", true, false, 35, "Zeynep", "(555) 567-8901", 14, "105", "Yıldız" },
                    { 7, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5435), null, 2, "can.aksoy@email.com", "5555789012", true, false, 41, "Can", "(555) 578-9012", 4, "106", "Aksoy" },
                    { 8, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5438), null, 6, "elif.ersoy@email.com", "5555890123", true, false, 34, "Elif", "(555) 589-0123", 8, "107", "Ersoy" },
                    { 9, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5441), null, 4, "burak.taskin@email.com", "5555901234", true, false, 72, "Burak", "(555) 590-1234", 7, "108", "Taşkın" },
                    { 10, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5458), null, 1, "deniz.akin@email.com", "5556012345", true, false, 71, "Deniz", "(555) 601-2345", 2, "109", "Akın" },
                    { 11, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5464), null, 7, "aylin.gunes@email.com", "5642597451", true, false, 35, "Aylin", "(555) 612-3456", 12, "110", "Güneş" },
                    { 12, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5476), null, 7, "eren.akcay@email.com", "5642517451", true, false, 41, "Eren", "(555) 623-4567", 12, "111", "Akçay" },
                    { 13, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5478), null, 7, "gulay.kaya@email.com", "3462517451", true, false, 72, "Gülay", "(555) 634-5678", 12, "112", "Kaya" },
                    { 14, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5481), null, 7, "cem.yildirim@email.com", "3434517451", true, false, 35, "Cem", "(555) 645-6789", 13, "113", "Yıldırım" },
                    { 15, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5484), null, 7, "dilara.cetin@email.com", "3434546751", true, false, 72, "Dilara", "(555) 656-7890", 13, "114", "Çetin" },
                    { 16, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5487), null, 7, "mert.saglam@email.com", "3432209751", true, false, 41, "Mert", "(535) 896-4526", 13, "115", "Sağlam" },
                    { 17, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5489), null, 7, "gulsum.aydin@email.com", "3432906751", true, false, 34, "Gülsüm", "(555) 667-8901", 12, "116", "Aydın" },
                    { 18, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5493), null, 7, "emre.yaman@email.com", "3850906751", true, false, 34, "Emre", "(555) 678-9012", 13, "117", "Yaman" },
                    { 19, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5496), null, 5, "selin.erdogan@email.com", "3850915851", true, false, 41, "Selin", "(555) 689-0123", 11, "118", "Erdoğan" },
                    { 20, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5498), null, 3, "onur.akbas@email.com", "3850926751", true, false, 35, "Onur", "(555) 690-1234", 10, "119", "Akbaş" },
                    { 21, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5501), null, 6, "melis.yilmaz@email.com", "3880226751", true, false, 34, "Melis", "(555) 701-2345", 9, "120", "Yılmaz" },
                    { 22, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5504), null, 7, "meryem.kuzey@email.com", "3972226751", true, false, 35, "Meryem", "(555) 634-5358", 12, "121", "Kuzey" },
                    { 23, 0, new DateTime(2024, 2, 2, 15, 23, 37, 598, DateTimeKind.Local).AddTicks(5507), null, 7, "ali.atabey@email.com", "1971927981", true, false, 34, "Ali", "(555) 186-2565", 12, "122", "Atabey" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "AppointmentEndHour", "AppointmentStartHour", "CreatedDate", "DeletedDate", "Description", "DoctorID", "EmployeeID", "IsActive", "IsDeleted", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 2, 2, 15, 23, 37, 596, DateTimeKind.Local).AddTicks(9452), null, "Regular Checkup", 1, 1, true, false, null },
                    { 2, new DateOnly(2024, 1, 1), new TimeOnly(8, 20, 0), new TimeOnly(8, 0, 0), new DateTime(2024, 2, 2, 15, 23, 37, 596, DateTimeKind.Local).AddTicks(9484), null, "Regular Checkup", 2, 2, true, false, null }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreatedDate", "Date", "DeletedDate", "DoctorID", "EndTime", "IsActive", "IsDeleted", "LastModifiedDate", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3637), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 2, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3648), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 3, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3650), new DateOnly(2024, 1, 2), null, 1, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) },
                    { 4, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3652), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 20, 0), true, false, null, new TimeOnly(8, 0, 0) },
                    { 5, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3655), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(8, 40, 0), true, false, null, new TimeOnly(8, 20, 0) },
                    { 6, new DateTime(2024, 2, 2, 15, 23, 37, 597, DateTimeKind.Local).AddTicks(3657), new DateOnly(2024, 1, 2), null, 2, new TimeOnly(9, 0, 0), true, false, null, new TimeOnly(8, 40, 0) }
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
