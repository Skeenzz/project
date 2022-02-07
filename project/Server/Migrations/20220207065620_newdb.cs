using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Server.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoingTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfVehicles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seat = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "FlightBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Passenger = table.Column<int>(type: "int", nullable: false),
                    FlightsId = table.Column<int>(type: "int", nullable: true),
                    Departing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returning = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightBooking_Flights_FlightsId",
                        column: x => x.FlightsId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Passenger = table.Column<int>(type: "int", nullable: false),
                    luggage = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclesId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBooking_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "68be161d-659b-46be-a1e5-ed3f410b1287", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "430bfb0c-7cd4-4261-a5b4-1d2b83a4f566", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "db4f2494-4a13-4326-a4b1-dfe2ebb1460a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEIMKyGWoAEzFTOj9Q/BPHwJr73MWBpi8fRxNeDtZ4/QQ132nbne7/nPfUSYi6LnXSA==", null, false, "a74dfb59-4da8-45aa-add0-fcde0ffdf711", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "CardType", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "debit cards", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "credit cards", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "GoingTo", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4739), new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4747), "Japan", 780.0, "System" },
                    { 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4751), "USA", 1780.0, "System" },
                    { 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 2, 7, 14, 56, 20, 284, DateTimeKind.Local).AddTicks(4754), "China", 580.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "Seat", "TypeOfVehicles", "UpdatedBy" },
                values: new object[,]
                {
                    { 19, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1323), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1324), "Mercedes Benz S Class", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 20, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1325), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1326), "Porsche Panamera", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 21, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1328), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1329), "Nissan Kicks", 120.0, 5, "Compact SUV", "System" },
                    { 22, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1330), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1331), "Nissan Rogue", 150.0, 5, "MidSize SUV", "System" },
                    { 23, 5, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1336), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1337), "Ford Edge ", 180.0, 5, "Standard SUV", "System" },
                    { 24, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1339), "Chevrolet Tahoe ", 200.0, 7, "Full Size SUV", "System" },
                    { 25, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1340), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1341), "Infiniti QX80", 250.0, 7, "Luxury SUV", "System" },
                    { 29, 7, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1349), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1350), "Chevy Suburban", 220.0, 8, "Premium SUV", "System" },
                    { 27, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1345), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1346), "Volkswagen Atlas", 180.0, 7, "Premium Crossover", "System" },
                    { 28, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1347), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1348), "Mercedes Benz GLE", 220.0, 5, "Luxury Elite SUV", "System" },
                    { 18, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1321), "BMW 7 Series", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 30, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1352), "BMW X3 ", 250.0, 5, "Premium Elite SUV", "System" },
                    { 31, 5, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1354), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1355), "Chrysler Pacifica ", 200.0, 7, "7 Passenger Minivan", "System" },
                    { 32, 5, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1356), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1357), "Toyota Sienna", 220.0, 8, "8 Passenger Minivan", "System" },
                    { 26, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1342), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1343), "Cadillac XT4", 180.0, 5, "Standard Elite SUV", "System" },
                    { 17, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1318), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1319), "Mercedes AMG E53", 200.0, 5, "Executive Luxury Car", "System" },
                    { 13, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1309), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1310), "BMW 5 Series ", 180.0, 5, "Premium Elite Car", "System" },
                    { 15, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1314), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1315), "Chrysler 300", 190.0, 5, "Luxury Car", "System" },
                    { 1, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 282, DateTimeKind.Local).AddTicks(1715), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(430), "Mitsubishi Mirage", 40.0, 4, "Economy Car", "System" },
                    { 2, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1277), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1282), "Nissan Versa", 60.0, 5, "Compact Car", "System" },
                    { 3, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1285), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1286), "Toyota Corolla", 75.0, 5, "MidSize Car", "System" },
                    { 4, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1287), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1288), "Volkswagen Jetta", 80.0, 5, "Standard Car", "System" },
                    { 5, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1290), "Chevy Malibu", 85.0, 5, "Full Size Car", "System" },
                    { 6, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1293), "Ford Mustang Convertible", 90.0, 4, "Convertible Car", "System" },
                    { 16, 3, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1316), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1317), "Maserati Ghibli", 190.0, 5, "Executive Luxury Car", "System" },
                    { 7, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1294), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1295), "Dodge Challenger", 120.0, 4, "Sporty Car", "System" },
                    { 9, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1299), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1300), " Audi A5 Sportback", 180.0, 5, "Full Size Elite Car", "System" },
                    { 10, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1303), "BMW 228i Gran Coupe", 180.0, 5, "Standard Elite Car", "System" },
                    { 11, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1304), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1305), "Tesla Model S", 180.0, 5, "Luxury Elite Electric Car", "System" },
                    { 12, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1308), "Chevrolet Impala", 180.0, 5, "Premium Special Car", "System" },
                    { 33, 12, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1358), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1359), "Ford Transit Wagon", 230.0, 12, "12 Passenger Van", "System" },
                    { 14, 4, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1312), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1312), "Nissan Maxima ", 180.0, 5, "Premium Car", "System" },
                    { 8, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1296), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1297), "INFINITI Q50", 150.0, 5, "Full Size Elite Car", "System" },
                    { 34, 2, "System", new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1361), new DateTime(2022, 2, 7, 14, 56, 20, 283, DateTimeKind.Local).AddTicks(1361), "Ford Transit Wagon", 250.0, 15, "15 Passenger Van", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBooking_FlightsId",
                table: "FlightBooking",
                column: "FlightsId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBooking_VehiclesId",
                table: "VehicleBooking",
                column: "VehiclesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Card");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "FlightBooking");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "VehicleBooking");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
