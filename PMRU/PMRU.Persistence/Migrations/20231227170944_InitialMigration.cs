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
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
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
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Day = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentDescription", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3679), null, "Güvenlik", false, false },
                    { 2, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3693), null, "Üretim", false, false },
                    { 3, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3695), null, "Finans", false, false },
                    { 4, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3697), null, "İnsan Kaynakları", false, false },
                    { 5, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3699), null, "Satış Pazarlama", false, false },
                    { 6, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3700), null, "IT", false, false },
                    { 7, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(3702), null, "Sağlık", false, false }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "IsLocationCenter", "LocationDescription" },
                values: new object[,]
                {
                    { 34, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6915), null, false, false, true, "Genel Müdürlük" },
                    { 35, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6918), null, false, false, false, "İzmir" },
                    { 41, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6920), null, false, false, false, "İzmit" },
                    { 71, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6924), null, false, false, false, "Kırıkkale" },
                    { 72, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6922), null, false, false, false, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "PositionDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7564), null, false, false, "Güvenlik Şefi" },
                    { 2, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7567), null, false, false, "Güvenlik Görevlisi" },
                    { 3, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7568), null, false, false, "Elektrik Mühendisi" },
                    { 4, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7569), null, false, false, "Makine Mühendisi" },
                    { 5, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7570), null, false, false, "Muhasebe Uzmanı" },
                    { 6, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7572), null, false, false, "Personel Uzmanı" },
                    { 7, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7574), null, false, false, "İnsan Kaynakları Uzmanı" },
                    { 8, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7576), null, false, false, "Yazılım Geliştirici" },
                    { 9, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7577), null, false, false, "Test Uzmanı" },
                    { 10, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7579), null, false, false, "Finans Uzmanı" },
                    { 11, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7581), null, false, false, "Pazarlama Uzmanı" },
                    { 12, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7582), null, false, false, "Doktor" },
                    { 13, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7584), null, false, false, "Hemşire" },
                    { 14, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(7585), null, false, false, "Satış Temsilcisi" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(5598), null, "aylin.gunes@email.com", "12345678901", false, false, 35, "Aylin", "Password", "5556123456", "102", "Güneş" },
                    { 4, new DateTime(2023, 12, 27, 20, 9, 44, 362, DateTimeKind.Local).AddTicks(5605), null, "eren.akcay@email.com", "12345678923", false, false, 41, "Eren", "Password", "5556234567", "103", "Akçay" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6018), null, 4, "ahmet.yilmaz@email.com", "5555123456", true, false, 34, "Ahmet", "(555) 512-3456", 4, "100", "Yılmaz" },
                    { 2, 0, new DateTime(2023, 12, 27, 20, 9, 44, 363, DateTimeKind.Local).AddTicks(6022), null, 4, "ayse.kaya@email.com", "5555234567", true, false, 41, "Ayşe", "(555) 523-4567", 3, "101", "Kaya" }
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
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "Employees");

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
