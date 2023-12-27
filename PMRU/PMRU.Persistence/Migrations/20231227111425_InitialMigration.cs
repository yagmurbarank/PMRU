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
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Appointments_Employees_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
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
                        name: "FK_Availabilities_Employees_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentDescription", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9117), null, "Güvenlik", false, false },
                    { 2, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9132), null, "Üretim", false, false },
                    { 3, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9133), null, "Finans", false, false },
                    { 4, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9135), null, "İnsan Kaynakları", false, false },
                    { 5, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9137), null, "Satış Pazarlama", false, false },
                    { 6, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9138), null, "IT", false, false },
                    { 7, new DateTime(2023, 12, 27, 14, 14, 24, 762, DateTimeKind.Local).AddTicks(9140), null, "Sağlık", false, false }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "IsLocationCenter", "LocationDescription" },
                values: new object[,]
                {
                    { 34, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5078), null, false, false, true, "Genel Müdürlük" },
                    { 35, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5080), null, false, false, false, "İzmir" },
                    { 41, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5083), null, false, false, false, "İzmit" },
                    { 71, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5085), null, false, false, false, "Kırıkkale" },
                    { 72, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5084), null, false, false, false, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "PositionDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5621), null, false, false, "Güvenlik Şefi" },
                    { 2, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5623), null, false, false, "Güvenlik Görevlisi" },
                    { 3, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5625), null, false, false, "Elektrik Mühendisi" },
                    { 4, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5626), null, false, false, "Makine Mühendisi" },
                    { 5, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5628), null, false, false, "Muhasebe Uzmanı" },
                    { 6, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5629), null, false, false, "Personel Uzmanı" },
                    { 7, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5631), null, false, false, "İnsan Kaynakları Uzmanı" },
                    { 8, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5633), null, false, false, "Yazılım Geliştirici" },
                    { 9, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5635), null, false, false, "Test Uzmanı" },
                    { 10, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5636), null, false, false, "Finans Uzmanı" },
                    { 11, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5638), null, false, false, "Pazarlama Uzmanı" },
                    { 12, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5639), null, false, false, "Doktor" },
                    { 13, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5641), null, false, false, "Hemşire" },
                    { 14, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(5643), null, false, false, "Satış Temsilcisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "RoleDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(6197), null, false, false, "SystemAdmin" },
                    { 2, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(6199), null, false, false, "LocalAdmin" },
                    { 3, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(6200), null, false, false, "Doctor" },
                    { 4, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(6201), null, false, false, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Discriminator", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Phone", "PositionID", "RegistrationNumber", "RoleID", "Surname" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(4349), null, 4, "Employee", "ahmet.yilmaz@email.com", "5555123456", true, false, 34, "Ahmet", "(555) 512-3456", 4, "100", 4, "Yılmaz" },
                    { 2, 0, new DateTime(2023, 12, 27, 14, 14, 24, 764, DateTimeKind.Local).AddTicks(4353), null, 4, "Employee", "ayse.kaya@email.com", "5555234567", true, false, 41, "Ayşe", "(555) 523-4567", 3, "101", 4, "Kaya" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DepartmentID", "Discriminator", "Email", "IdentityNumber", "IsActive", "IsDeleted", "LocationID", "Name", "Password", "Phone", "PositionID", "RegistrationNumber", "RoleID", "Surname" },
                values: new object[,]
                {
                    { 3, 0, new DateTime(2023, 12, 27, 14, 14, 24, 763, DateTimeKind.Local).AddTicks(3634), null, 7, "Doctor", "aylin.gunes@email.com", "12345678901", false, false, 35, "Aylin", "Password", "5556123456", 12, "102", 3, "Güneş" },
                    { 4, 0, new DateTime(2023, 12, 27, 14, 14, 24, 763, DateTimeKind.Local).AddTicks(3640), null, 7, "Doctor", "eren.akcay@email.com", "12345678923", false, false, 41, "Eren", "Password", "5556234567", 12, "103", 3, "Akçay" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");
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
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
