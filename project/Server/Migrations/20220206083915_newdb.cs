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
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    FlightsId = table.Column<int>(type: "int", nullable: true),
                    PriceId = table.Column<int>(type: "int", nullable: true),
                    GoingToId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_FlightBooking_Flights_GoingToId",
                        column: x => x.GoingToId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlightBooking_Flights_PriceId",
                        column: x => x.PriceId,
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
                    TypeOfVehicleId = table.Column<int>(type: "int", nullable: true),
                    PriceId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBooking_Vehicles_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleBooking_Vehicles_TypeOfVehicleId",
                        column: x => x.TypeOfVehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "a8d5af15-70b2-4228-82c7-7ca6d4dac719", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5e96405d-47c7-4f82-9ec1-5806053caad8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "532ba015-b055-4346-9582-db83fcd7826f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEL7Q6s5GQrW9EM3oNrfdL6VBtTfWJaSKZWwjUBXCPWhxCGVSBEJGEY8vmjLVAX8bzg==", null, false, "c6c7f3a2-d4c1-4edc-aa88-e543782ff14f", false, "Admin" });

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
                    { 1, "System", new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9387), new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9394), "Japan", 780.0, "System" },
                    { 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9399), "USA", 1780.0, "System" },
                    { 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9400), new DateTime(2022, 2, 6, 16, 39, 15, 290, DateTimeKind.Local).AddTicks(9401), "China", 580.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "Seat", "TypeOfVehicles", "UpdatedBy" },
                values: new object[,]
                {
                    { 19, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5368), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5369), "Mercedes Benz S Class", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 20, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5371), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5372), "Porsche Panamera", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 21, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5373), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5374), "Nissan Kicks", 120.0, 5, "Compact SUV", "System" },
                    { 22, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5376), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5376), "Nissan Rogue", 150.0, 5, "MidSize SUV", "System" },
                    { 23, 5, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5378), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5379), "Ford Edge ", 180.0, 5, "Standard SUV", "System" },
                    { 24, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5381), "Chevrolet Tahoe ", 200.0, 7, "Full Size SUV", "System" },
                    { 25, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5383), "Infiniti QX80", 250.0, 7, "Luxury SUV", "System" },
                    { 29, 7, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5393), "Chevy Suburban", 220.0, 8, "Premium SUV", "System" },
                    { 27, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5387), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5388), "Volkswagen Atlas", 180.0, 7, "Premium Crossover", "System" },
                    { 28, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5389), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5390), "Mercedes Benz GLE", 220.0, 5, "Luxury Elite SUV", "System" },
                    { 18, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5366), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5367), "BMW 7 Series", 250.0, 5, "Large Executive Luxury Car", "System" },
                    { 30, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5394), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5395), "BMW X3 ", 250.0, 5, "Premium Elite SUV", "System" },
                    { 31, 5, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5396), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5397), "Chrysler Pacifica ", 200.0, 7, "7 Passenger Minivan", "System" },
                    { 32, 5, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5480), "Toyota Sienna", 220.0, 8, "8 Passenger Minivan", "System" },
                    { 26, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5386), "Cadillac XT4", 180.0, 5, "Standard Elite SUV", "System" },
                    { 17, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5364), "Mercedes AMG E53", 200.0, 5, "Executive Luxury Car", "System" },
                    { 13, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5354), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5355), "BMW 5 Series ", 180.0, 5, "Premium Elite Car", "System" },
                    { 15, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5359), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5360), "Chrysler 300", 190.0, 5, "Luxury Car", "System" },
                    { 1, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 288, DateTimeKind.Local).AddTicks(5338), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(4443), "Mitsubishi Mirage", 40.0, 4, "Economy Car", "System" },
                    { 2, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5321), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5326), "Nissan Versa", 60.0, 5, "Compact Car", "System" },
                    { 3, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5331), "Toyota Corolla", 75.0, 5, "MidSize Car", "System" },
                    { 4, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5332), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5333), "Volkswagen Jetta", 80.0, 5, "Standard Car", "System" },
                    { 5, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5334), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5335), "Chevy Malibu", 85.0, 5, "Full Size Car", "System" },
                    { 6, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5337), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5338), "Ford Mustang Convertible", 90.0, 4, "Convertible Car", "System" },
                    { 16, 3, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5361), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5362), "Maserati Ghibli", 190.0, 5, "Executive Luxury Car", "System" },
                    { 7, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5339), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5340), "Dodge Challenger", 120.0, 4, "Sporty Car", "System" },
                    { 9, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5345), " Audi A5 Sportback", 180.0, 5, "Full Size Elite Car", "System" },
                    { 10, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5348), "BMW 228i Gran Coupe", 180.0, 5, "Standard Elite Car", "System" },
                    { 11, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5349), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5350), "Tesla Model S", 180.0, 5, "Luxury Elite Electric Car", "System" },
                    { 12, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5352), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5353), "Chevrolet Impala", 180.0, 5, "Premium Special Car", "System" },
                    { 33, 12, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5483), "Ford Transit Wagon", 230.0, 12, "12 Passenger Van", "System" },
                    { 14, 4, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5357), "Nissan Maxima ", 180.0, 5, "Premium Car", "System" },
                    { 8, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5342), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5343), "INFINITI Q50", 150.0, 5, "Full Size Elite Car", "System" },
                    { 34, 2, "System", new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5484), new DateTime(2022, 2, 6, 16, 39, 15, 289, DateTimeKind.Local).AddTicks(5485), "Ford Transit Wagon", 250.0, 15, "15 Passenger Van", "System" }
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
                name: "IX_FlightBooking_GoingToId",
                table: "FlightBooking",
                column: "GoingToId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBooking_PriceId",
                table: "FlightBooking",
                column: "PriceId");

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
                name: "IX_VehicleBooking_PriceId",
                table: "VehicleBooking",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBooking_TypeOfVehicleId",
                table: "VehicleBooking",
                column: "TypeOfVehicleId");
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
