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
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    imgName_flight = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reviews = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfVehicles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seat = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Babyfriendly = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Petfriendly = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "PackageBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageBookings_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "e1df52e6-8470-415e-9d53-904ca9b1a4f3", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "0962e797-0b25-4a36-ad1f-141f21f1606f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b13484bd-3176-4699-8938-eb5f93b1f471", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEOtV9LYP9T1cd1pSDUawWqPuOOTEwIWvJPupw8X7b4UaivhODrxf4uGWip+cst4Spg==", null, false, "7f887755-53df-4f86-9d57-bddd2dbc295f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "PaymentType", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PayPal", null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paylah", null },
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "debit cards", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "credit cards", null }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "GoingTo", "Price", "UpdatedBy", "imgName_flight" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(541), new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(544), "China", 580.0, "System", "url" },
                    { 2, "System", new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(536), "USA", 1780.0, "System", "url" },
                    { 1, "System", new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(483), new DateTime(2022, 2, 9, 9, 1, 17, 771, DateTimeKind.Local).AddTicks(524), "Japan", 780.0, "System", "data:image/jpeg;base64,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" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "PackageCapacity", "PackageName", "Price", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "something", 80, null });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "ProfilePic", "UpdatedBy", "reviews" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john tan", "url", null, "Drives too fast" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Babyfriendly", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Petfriendly", "Price", "Seat", "TypeOfVehicles", "UpdatedBy", "imgName" },
                values: new object[,]
                {
                    { 4, "Yes", 3, "System", new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4271), new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4274), "Volkswagen Jetta", "Yes", 80.0, 5, "Standard Car", "System", "Url" },
                    { 1, "Yes", 2, "System", new DateTime(2022, 2, 9, 9, 1, 17, 761, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(1008), "Mitsubishi Mirage", "Yes", 40.0, 4, "Economy Car", "System", "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBUVFBcVFRUYGBcaGBsaGxsbGyAbIBsbGhsaHRobGxshICwkHh0rIBsaJTYlKS4wMzMzGyI5PjkyPSwyMzABCwsLEA4QHhISHjQpJCkyMjIyNDI0MjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAK4BIgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAAEBQIDBgcBAP/EAEUQAAEDAgMEBwUFBAkEAwAAAAECAxEAIQQSMQVBUWEGEyJxgZGhMrHB0fAUQlJi4SNykvEHFRYzQ4KistIkU8LiY3Py/8QAGQEAAwEBAQAAAAAAAAAAAAAAAAECAwQF/8QAKREAAgIBAwQBBAIDAAAAAAAAAAECEQMSITEEE0FRYSIycYEUoZGx0f/aAAwDAQACEQMRAD8A5eoHf7vh41sNkNFLYSdSmT40idxACjBBUDZQ395IvaneyHStuT+YfH41Aosq2uhRbhOsgcbEEaeNZrEZtM2YSFG++IB1jQ+tanaqexfSUzuMSAb7rb6yziBeIABMakd00A+S/ZzqQ4kKIAJibQOZmtvhMQHWwoEGMySReSkxPp61gcNgXHXEttJUtatAkSec8Bz0rb9G+j+KaC23G9SlaCFJWL9laSUkgGAD4UnSDXFbNmZ6U4WHA4mwXY940Pl7qp2ahZaUQfacSD3Jvat/jOhynRDqsgmRBA3aSQbTyq7A9CUJSEhalQSbdrX91NJyRn34JmR2U8lTboVHWh0RyQEwAOUhWlSxmsWmI5A8TyitxhOgrTaioBQJ1lDh47pjfRSuibeuUHvacMxxk38aWr4E+pj6ZyXZxh5Cbe1lI77Eepo/EYeCOUH0/nXSFdFm5zFLOaZlTeUyN8kzVjuw1AScOhQ4oyqn+JIHrQ5/BP8AJVcHK22wXQOEkjuBI+NUZAk3vO73V1NGFw+fKpCEKNoU3kJ5CYCv8pNWK6PNXBaRcb0DTui1J5Pgh9UlymckSogzxGp9aLbSXAbgAa3BOvD410sdGWD/AITf8CRVn9jmiJDEDikqSTx0IpOd8CXURfhnNkYftwBAJIneBpzqteCWZECd5B9ru4fyrpI6Itbk5Txz6cpNCPdDCVfs1FJjcUH5GaNTLXUROZvDKSkgTvr5GHBHtHjP892tbLFf0e4gKKrmeKCLd4mluJ6Mvpt1QI35Tw74M1eovuR9meSAiJMmPrxqacqtR86uxOFU2e00pN/vJIE7oNDFwg6U+S7smhszc21/StZ0YQnq1gXPqSSI8BbzrIrdPdGlajYUtoWBJJ08AkjfxkeFBURhjLEHgVTHr6Ut2viOrbXKcwVKeQkSD3SKMWk5gBIuR7/rwpP0mVCBzMelMtmebRM5QeXdz41agqFo8xrXzCVBGbKIJiT8KPbbJAURrprpeDScqM2wUJClKJtYAd4J1qTbSQZM916NYwOdRSokTGWEFU3A0F/IH41XikAEgX42jQkCeBtOtD4sTYMtKfumgyjU3/TjVk3nfRDPaknQevfS4C6Ai0SPCoqRAjx/SnSLnKEGBuAk623aX17tKAxqT2pEQcsc+E/WtJStjW4POYhJIG6SYA4k0zU0nsoBIkAhSgey2AVLWZ3kjwsONAYXDZrlJI00Men1ei1rUpRJ1UBmG6BBi26YtyEzTe7pA2AdZ9SfnX1T6o19ToQerCpCAuUmZIE3AAB4wTBECKZdHYCFD86rk8hek+IHahCe0vtAA6TYDvBpt0eQcq5M9r0ygD3UxxLttn9mvkB7xWWwDZcdbbkjOtKP4lBOnl5Vqtrj9m5+6fQVb/Rx0cOKeDy5DbZnhmWNAOQ98cDQ3SCcqVm86L9GW2kktpypOqzdS44nf3aXorEYpanFN4dAUGzlW4tZQ2lUXSkJGZxYtNwkaTupnt3GFlhRbAz9ltsbusWcqPATJ7jS7BtBptLaRZI1OqibqUeJJJJPEmnjxp7s5oQT3luRThX/AL2Jyf8A0tIb9V5zUv6uJ9rEYlXe6U+iIFWl0191xrdQS8GmlegBbHVLOVx0kiO06tY7R1AUogEATQmHW4646rrnUIQQ2gIcKRKRK1cD7QHgatxGJAzLO5JX6Qn0Br7YbeXDt8VDOe9ZK/jHhTpDaRaj7Sj2MY6eTgbcH+0H1q5ra+IQf2jTbvFTctOeRMH+IVIq5V9nFJ44slxTD0PM4pCk5esH30LTlWnmU7+8eBNZXpGxi8G2XMIsOtC5StOdTYEzBJkp0teI7zThxqYUklK0+ytNlJ+Y4g2NMMDjSuQpMOAftEjRadOsQPeNd17E8+THp3XBlOGnflGIwvSZasOhasS2HQqV5W8wyqslJQEzMg9qU6jWrtk/b32VPq2ilppAkyhslO8AqypRMX1tI8F/Tvo2phJew4CsOsgrTGYIJIOZM6INhbu0NZTDbcQkKSpoBS4lwKunQFQzBWUwTcXv3RUdLXBrCMZK0kaz+0IBheOxK1aShtpOkkkZ06W0kd9LcT0jxCRmRjS5JISnq0Bdt6kwQnwJrPP7LkdY04Fi2a8FObTUydLEa+5Yk8aGl6L7cfS/wb0bS2qkJUjEAhV0hAQ5NiSJQmCQBJ/nA/8AajHhWV50iJkFtIVbSxi076zWG2ktARCyClZUIJSROoSRdM30O+nLm1/tBQiFE3BClXJjsqSoakaSqT76emNC7a9I2bG2Wn25RmSoJSFhSQvtbz1aTmUk3II4aWpK9gWXVFHV4frPu5Floqv+bTUe1E1mEYdwu5AhZVMKRckga5kjUA1qcX0aCkIdSC0qNGyVTzEmUxe0791JRXoWlRFeJ6Gu3CZSqfZWkgReCHAINtSQE8Ca0+z+jbiE5luISmNSbXi8m1LtnbcxGHhtxzMEjKJV7MxlBOoNhYzyrRo2khaklwCZn9okSCdVJULeMA8aelD1tcAqtl4cmS+g3J7MnXuJqL+xsG4IW6gjXtA/GnmIxKgAWmy7M3zBIEcSdR3A+FCOJxatOpbHMrcPplFWoxHrbE52Bggmz7JCQSEykxvOVMyTyGtUNYTCqjtmNI6twQBunIQKj0ixTxWELUgqbBMpBABULG5NxY0Ky2lKQlxp3NlvlhUnedbeVGlDGqtnYYkZX0hXBS0A+GYpPpV46MoVcqJCtVZMw43UFXvSht9kCAtQnUEKEegFTSlxuFNCJvmbKhm71AzP1FGlAH4noo0NFpVP5E/8poP+zITMBI7gb90CnWz9oqcQU4nsgg/tEgBbe6VwMqk69rKIi41NZTphh8cwtIL61NquhaVZUrG4yN+kj5ik0gpsYo2S4gFSZE3NjeNJJTFLMZsttSszjqUnNnusDtAATbkB5VmHkOyFLWombSsqM+Nes4crXMmQBcC9vjUNR5oaT9mowDbLKITiWlJH3SpUiTPtBMUjxuFbGYoeQSok5c4MSTABGusTG6hnMFJPtqUTvIjeTbwo/DMYcswpaw6CoBAJKVgwbiYExuO6oSjdpBwetYHC5RL4mBPsa76+pZ1I/Crz/wDWvKWn5Y6I43DwUQYN58/19Ka9G1dhdySFCfUD3UtxuFWok2NzpIj6+dMdhjIFynLOTUgT7W82HjTtGkISk0ktxt/V6nz1SNVyNNJ39166rsbZqMKyhpsQEi54nf8AHzpR0Q2YlLYcKm1KJuUHMCNwCuXLeK1RIpLd2cmZvU4vxsZHb2KC8Uw0TAQlTpGsrV2GxA5FauUCrisinGO2O06cykkL/EklJ5cj4g0pxGwHU/3T2b8rg/8ANP8AxreE0lTFCaSorLs76GxjgCCZ+jagtqIxraDDAKtyrrR3wiVecVjDtHFqd/bKAQARlQRlzWiRJVP71XrXg0TvgfbYxQDLl4zHLPAaH1zU2Z2kz2EpcTKgMqZuREi2oturCbZxmZgjmPNRk1m1vEZTv136zNJzoqrO1qfjUx31Au1xh3FrUrOpaiqZkkzTfZ/Sl5v21F1MaKPrmgmjuINLOpIxAFerfmFJVC0mUngeB4pOhHCsIxj9pvdprDqyk2lECP3lkSOYr3E7N2utJlpSRrCXET4ftJ8KTyR4IdcNo6dgMa282ZALayULQb5F6KQeRJ9fzWwm2ug7bb6Q2SiRKNyVKnsgrnMlUkDSNDa9KOhW0l4V51t0LCFZUuNrBBEz2oN558PCuqvYVGIaUw5CogpVAPNDg3T8Qd1c96ZfBjbxy+Dl2B2X1AcQt5TboN2nBAJj2g5OXebGxtrSJ3CB1aQlKUK0J0CzPtWsJF4E6b5rT49DuCcccW3KSrIpVnBxbUsLCj2gCAVW7KhYiql7UYfUMrDba0pUpa0ylMJTJPVJSRmtuVyrfZo6E/KM2vYrja1pIEtyojMLptCknRQ9bHfVbDIS+lskpCzkJIggqNo13wPGmu1HFFQD7SyFJhpaBo4R2eM8wFT8V+1XiuFLUetSLKMySmCJB0Ij6NJoZttntMsxmSoq3KmTbdHDuIiitn7fCXC2QlaCqVKMnISDPM6XMGPGs+l8vN5kOJClgaKEiwlMTIN/WgU7HdQoGEkRpmPLQRA0FOzJL2b7EYJp9JLamyoG4mRG/MPvA/mHjSX+rnMig2MyEGUgDQfli3kY8aQqexLcKQlYWLSFjTwM/WlG9GukrjSyl5DqEk+0ESEjS6YvuuPKnaY6YwwOOWgRcEGYMggiRbnqPE1psJtJC4CoCjYTYFX4eSuWh3cKE2tg2nUJcCk9rKUOJsCDpm1BG6d1LmWwiW3kTIsRcH5jkdLUNNCaBMUM7jmYEFTmWCLiTAEd0VqHurBgwDzqlOCbdQhYUSWykqOq0ZSCM+9xuwGa6k75EwBtfa6WFBLqVXuPZII4pJNxzpxl4ZTlZN3Yra19Zmk2mMu7uAM86rcwa2z2Csp3pSEn3wQeYNL07TwjnbCghfGMihuonDbTQBkTiEFU/fVNuAkD0p0FhKHw4qFhTbo9hREBY/Crnb60qbGLbKFYfEp/YE5Txw7m5ST/ANsz3CfwyBVinlZe3kWJ1AOm6wn31DDOh1QSpBzFJQHIJEC8KmJ4ifiaGikzPdI9nLwoWw7dMBTbgFlJBB87cZ3d6LCEwFIIMXKTZVhJi/aTzF+VdR2fs0YnDLwr/sJUoML1KQmUqAvdAIjKbx3A1zfaOzVYVxbLqIjQi5IJEKQT8NxNpBrLQkUFu40DtACVQZEeyBalyVSlSUpte86cbnebVRh8TCcplVxCriRzjVQ8+doPycUQkyAoTlE67pymRG7XW9QoVwTQYnArgdr3/OvqXfa/zfXnX1Tpl7F9XsZdZGgvoTeicFgVYlxKBKEphS1D61sQPHhQSoBkTAvyme7St3sTCdW2BEKV2ld53eAtU5KSNc3UPCrXPj/oxaYDaUoR2UpEJi0CjEbRdR94KH5rHzqhYmvGVQv28hggKIkTEXHCsE99jyNTcrsYp26B7SCPGR50S3tdCuPvpCtXaM5TeJTYHnH1pVam0m4seVV3JIO5JGsRjUH71V43AsuiHG0Ln8SQT4HWswFuJ35vfV7W0SIklNUsvspZT3G9BMKsHICib5T20z3KMjwIrLbU/o2Xq3BA/AqD/A5b/XW5a2meINGN7RSdbVosi9m0c79nDNpdFXmvaEfvpLfko9g+CqP6DbPUjGBTrdkNqUnMkKGaUgEagkSe6u1BxCrAj65Uo2h0cYckpR1a9c7Z6tU8bdlX+YGnKVqi3muLQwG0EBI0JPKq/trZF4Hiayj+xsUmQjFpUNweav4rQRPflpPtBe0WUlRaadSNVNZleJTOYeVY7v0ZJXxQ36aBtbRcAGduCFb4kSk8Rc2qPQLbvWS0s3ShIR+6Cox4ZvI8qxOJ6QuPpLSghsHfJJkEWjdQOy8WplxKkntJVr3H3HTxraMHppm0cctDUv0du2xs4YltSQQlzIpElIUlQVqlST7QsDyKUkXFcvZ2Yphz7NiE5FKPYXAGcRYociJ1lNprp2ytoodbQsaKFuXFJ7jai8SwhxJQ4hK0ncoBQPgbGpjNxMoZHHY5ljlKbbZ61fWN6gBIhKik5TMCeyTYniddEWK2K042p1tyVpOZxspg5CYzNkWKUzcRbXSuk4zoXglqSC0EiFGEKWgZuzAyhQTpmOk25UGv+jrBfhc5dsn31p3UzZZo/JzcYFbbYulSVkkDLmgpkHdrE+fK1Kc6DKHHExuBIHiNPSumI6D4NIIyu74JWCU/uyLaDyFeHoVgzqp4/wCfL/tAo7kQfUQ8nP29s4hGq0qH5kf8Y99Ft9KkCOsbBP5TPvFvOtkj+j7AqMZFkni4fnV5/o8wIE9Sq3/yLnxAVSWRC72N+GZfCdN2kqKeqUttX3FlMidcuoB7tadYHpLhCgIWCgXAK0kBI1BzRAPdvim2zuiuDSrIljKInNmWZkm09ZMjnxoxXRXBpVm+zJJG9aM1+RVNUsod2FWkzFvdMGsM4bqUtB7OWUkaa5gDHEEUuxO3k41xWRhSEBBUUlyUpyyVKRMZdPZTOhsa6GvY2GSSoMMZt5DaZPMnLc0QcOm2VCFC8iySk2ylIAv+gpPL8C78fCOXtbEW5HVmbT27eGeMp8x3V5iujWJyj/p1GNSghc84CiZro76VA3TlI5RU2MblPaEc0yD56xUrNvuSuq33Rzno8XMM82p1C0oSomFpUEmxiQRGtdQxW18K4nMhaBO6Y9KmnFBQIUlLiTYhQFxvm0HyoM7JwS9GG0ngEhPusa0WRSNoZYy4ZPZmJSpfVBdlmUEXyrFwRyN5FT25sZvHNFtwBDrdkq1yn4tnX6IKfEdH8rqVtOONR+Ej5U/w+HWkSp3rDlygkQbkRJGt/KTVml0clxH/AEynGsSyc5HZUSUxrCxFiPS2tAO41rLcg8CPceNdwx2BbeTkeaQ6ncFpBjuOo8KTp6JYVJltpoclNpPrHwphS5OP/amOP+k/Kvq7J/Zxv/sMef8A619RQzleFalxA1laR5qFdFbXAvXP9noIdbJH30026T9JPs4SlACnCJE6JTxPE8q5MicmkjDqoOUlFGvRiAa8drm+yemy84S+lJST7SQQRzIm47r99dBbezCZBm8jfOhrKUXHk48mKWPk+zVIOVSqvJqDOglK6koyN07qGCqkF0w4CU4UEShYzbx7MHgDJHnFRC1p1E++1fBxsphbYURooEpUPEXivEKgRQ6G68F7eMG+3fRSMRzoApBqstEeyYoEMVuUKtEm1Udaoaie6rWngf1ospMAxvR9l5WZ1GZXGSD/ABAg0lxXQVCieqdUiNyxnEndIgjdx1raJUK+aGp4n3QPhVqclwyo5ZR4Yu6K7Ocw7RbcUlRKiezMAQBvA4TpvrUsOpiPfxpYKuQqjU7sWtt2w1bUixg6g8DuP1umvBiSn2wU89U/xDQfvRVCVkVah80WOy9IbWJsQd4P0Kqf2dN0weVSCW1GSmD+JMpPioRPcaX4zaS2nQ2iHBlCoPZVqZggQREWjjfSrjHVwXGGrZBCmstsvnY14mbe1O4H4cfCpYPpCw52VKyqkiFRqNbiY8Yo1WFSoShUg8DI8DQ4tClja8C9Zk318/1qwPriBcfXjXzrZSbg+PzqLauRB4cfGptmdtM8Usmxbme/0vVTgi+X1Jir1Oz90VWVX0FJsHIHLiibqUe8+l6pdRmMwfL5Cj1LT+AVAqTuT6mj9i/YInBAXC4V+GLHxNWIIBhY8r9/0akQOFVOEHQR3UrQWghywBSoEbgRQ6toxAI+8n/cKrBIqjFIzCd4IPkZrWGWnT4NsWdp0+By3tFsmMwkaiQY7xNXjEpO+sMwwhDhclUkmRMiTrunfbvpknFcK6Yt1uehLSn9LNT1g4j0r6kXVOcPUV9TEYBhsJUkwU3HLfvBItz31mekSy7i3AdEmPBIAPrW9xihm7PaSVcAAABuMTPjWXZ2WXcapOWQtWfvSEZvIm1c8JJyLlvJP4AsPs1wpGVrsxIFpI4hJOY/GtL0Rx1iyToJR+7vT4GPBXKtFiUqWwwtMS24425EGMzZUkE7oUdOJrEqd6t1p8WQslWkSmYUYn8JBneZPCtMkLjRGWOuLRuig1ApNeJxRHMcD8KIQ+hXI8/nXEeW7RRNeZqJWxVC2jQB6FVYFVTFeg0hUXhVSCqoCqkFUBQSFVAtg1AKqSV0wPQlSdDVuHxBGo3n3mopVU8O4QARFx79aENVe4WhU0S0iaEC5MwByFXIeHEedPyGyYUlE16E1WhzhVyDVFHosKyPTZlSQ2+hShHYVBI1MpPqq/dWtUZoXH4RLra2l+ysR3HcfAwfCqhLTJMvHLTJMkyz1gbbxLCYKAOsbX7PZmDfNFtSTJ3VY3sFxvMW3FxPYy5dPzJMSB+9eqtiMlSIUcxASF3gpcSqFCCPYmDqdQdFCdAMQUJgIK8vZBG/L512cnoUmJWcViU9nEMKIMwtACtPxJSTBPAT31chCV3bUD3GO+1GsbYznIWymZ3zp4ChtqYRtxWbOppY0WiBN4Enf48ah4k9zLJhjLgFUgpN68kcKGcxbrSZfhxqQOsQCCmdM6Tp36c5tUm3+sTnbSSniSkDuIBJB5ETXNPHKJxZMMoFhqJqpRc/KnzV/wAarUlf4yP3QB7wayMqLVCqFuJBgqSDzIqKmgdSo96jHikQPShceoNICklKQFJnsmCCYKYAmbiDxihK3QKNukWrxDf40fxD51UvEJ3EnuSojzAipMYhLglBkAkHcQRqCDcGvlmh7CarZifHwEuK4IzD/KofBR9KzO0elJaTDaZcIsToOdbHENhSXUxJU0sDvifhXJNrtLDziFpyqSopIAgW4RaP0rrxzuKPT6dqUUSO38Ub9cu/d8q+ob7OONfVodFI3DzzgJUUwEwIy2CYGhmTrJtaav2IkuYtRT2VDDLWnfdKgQZ3g8q8yGFAE3kxIiZvB+t2leYN4tYtpaFQVgtqmIGcZQmdIkjyrnxRqVsrt6VZqStWdxuEoX1iJJ7IcWn2Vm+hScs8Ub6wvSVDyHXGnkZQgpCOyQlSSkypBgApsBbhWvKFNuFeJhSVOobKQTYLJQqTxkg9yRxrPdMX3kA4d4z1bqurMzmbA7Bg6HKoTFq6mQgvZOK6xlCt4TB709k+6fGiwuud4PbDjJPVqETJB0nlvGla3A7azoSpaU3AJgwQTztPrXHPG07OPJhkm2uB61iVJ0NFox4MZh4j5UmQ82rRcHgr5gfCrSlQvEjiL+caeNZ0czgPEZVeyQaipmkqHeFGNbQUNbjn86midLCSgiozViMYhWtqsLYNwQaYikKqQVXimyKhQMuUux7jVoXFCKVbxHqRXz7wSComAASTwA1oCizEYxKElS1hKRqSYA8TSdXTHCAx1pPMJUR55b1z7pBtleJcJJhAJyJ3AcT+Y8aWs4dS9BbidK6I4dtzth0qr6jtWzNssvf3TqVHWAYUO9Jv6U8w2J3GuDowikwpJIIuCJBB4gi4NbXo30tUCGsSbmAhw2k7gvgeCvPjUyxOO6M8nTOO8dzp6DXxM0uwGJvlXpupw00DeoirMYqwZhC21lxtIVmGVxExnG4gm2cC14kb7CjcY44lBDQBUQPagwZFzziRrXjjiUCvPtkCRx0NbxyaVR0wyuKoLx+MUEIgJn719IFwOO/ypLsrGN4ltba3EnMZSnNCjCgqQNbEA240anHzYgQfq9UpQwTPUoCuISJ8wBVLMi/5C5IYrE9ScoEtlEqzGEpEkGbQLbtKz3RxaHHUqwyVIaSHEuWISpOclsidbGANQE1p38Iy6IWjNvhUn3mpFtttGVAypG4CBSnktE5MupVQIul2OxqGk5nFpQniowKOWscRSrGYBl1UvJSsJ9kEBQHEwd9cpxur3E2K6aYNH+Lm/dBV6gRQD3S8ODK3hHnQeKeyd4rTN4Vhv2G20/uoA9wqxWKQNBTuK8FKUFwv7MqNo7RWexhEtzeVKGvEgXqadnbRc/vMS21yQnMf9VPcRtJKRJypHFRj30of6UNCYcCuSAVf7QaabfCGnJ/bH+r/ANjPCMloJzLUsp1KolUiDoI8KwHTlKftZUkQChNhxEz9cq1rmKzAKBkEAjuNYfpO5mdT+571K+VXiuzbpb1bibPX1MmW05RpoPdX1dJ3GtK7QJkaQZkT323UDtAEouDMggyPEDzpo5GYjtEAchEkXJjnUHECBztBm4tAPPh3VmmbNFjfSNp5sjE9ZnGQhSEpOYo0KpIhUgT41lOk2214hzOo6JCEjglIgd51JO8k02xmx21mcxR3RFrTHw9aWu9G7n9oT3iK01GekzoEmPPuph9qANifP3UYvYCR94zzPx86pVgY0QN3H51NjpladorT7Kjz3g+BkUZhukake0k96THobeUUD9nInj3VUUcvPnScYvkzljjLlGtwvSVtdlFJP5uwr+Kb/wAVNEPtK0UUngq487W865ytvcRFfMuuIuhahyGninQ1DxLwYy6ZPg6YG1boV+6Z9NfSvkPEHWDWFw233ERmAI5dk/L0p3helaFQFn+Me5V48xWTxyRzywSRq0YxW8zVwxAO6kzG0GliZKeYOZPv/wDKjECfZUlXjB9Y9JqKMHBoKWr3j3g0j6Y4rJhVAarIR4G59BTXMQQCCDzEbjWZ6eL/AGbY4rV/tpwVyReKNzSMXhmcxvoPU8KZssrX7IsNToB4/AXqGzsNmKEC2Y3PAak+AHpW221sppGC+0NoUpLcJUgKsJjKsmJKbyeJmu09QzGJ2a81BUmxH3SDprbWqEALBB1I42PKn218aTgmXRAUrLeNDlBUR5Ggcds5aGkPGyjHWAWgn2VRxuAedAjQ9ENqlaSy4ZcbHZJN1IFrneU2HcRzrdYTFnLr31xzD4tTbiHUicpvEXH3h4ia6fg3wYIMhQBHcbg1y5I6ZWvJwZ4aJWuGOnHCoGTcUN1leIcg1Q8YURPMdxrNsxbLi5XyXiNKGK68K6Vk2Gfa1cT51U5iSdTQpXVa10ah2y1bpoZblRWuqFroJJLcpE1hnMQHHFOOBtK3E5ULyWbyAWCZVKlX7QgDjTVaqRIwSkW68pSCsgJCQf2hJX2oKri1iLDvrTFKKdyOjDpi25DzZ+xMKJ6xtGZKCVKWApSYJGcFxbgBJkBPaEoV2jFC4raDKCpCHGz2AnKiF51ZMpkNjsqCznk/hi00odw+HSB1hK40K1FURwzG3hQuI28w3ZME8EifkPWt+7f2o6Vkb+1DpVkgcAB5CsHtbFZ31flhPlr6k1q9i4teILiymEIAi+pIJvuGg86yGNwi8ylkXUoq8zMVGONSdiwQqTs8zHia+ofOa+rc6TpVhaTxvbdf6/SpuIUCDmlJ0MKvE8YMaV6UTqopEazMTyJE/pNqqQDrfS+k7otxndeszY9UveAJM+XLl+lRUoEXPlM8RHjUgAQDJIiTY6cwAeNQRygTyJ33kbt2tBJWtsE6yN9+HhaoHD6Ru4DTmY31eixGkR3fz/WprQYT2lCSQASBvGs2A3zYfAHQsXhQTOWDpuEciOdCuYEToOe4291OF5hmJJsTmIM74MkEzxjfUVtgLTOUg5T2Y0O6funlxFDYKJm3sLFyB4++hjhDaBMg8/OdPrvrRoUPvGTJI0IJuNRIma8Wyk5pvxgDWx1yxPOe6hMTiZRbR3zOt+cfOq1Mz/L41o1YdCp7J4iIAkxYiIG7SNKXqwpgnvO/uHqDTTJaFCVFF0qUk/lMUfhttOt6kK9D5i3mDXisPyJP1v31Qtjy+tabSfJDinyaDC9LBELCh6+Mj5VHpLjUvspLXaKVXAuYIIJgcwKz5aiDaO70+uVVBEXEg8rH0qVjSdojsxT1I0/RXCFbi4uUtKgcTKYitBsjaScO4nCupKmnG+rcBSYkgk6i4gnTn4IuiDalulCSMymlFM7ykgx5TTlW2X2y0hSUKDoAGUkqQTAI1lKk5ga0NA3H7IZbbQzJUltQW2SoEqSFGxEXSZieXfSlzDOv53RAabJSuTdSSSlwJTugZrmLitLhscUXSjMQNFJUTyyjW8i+nnS9zb+HWt1GRttxZh1KlKGY8wSAfCnsIw2QpzoNykka70ki1bbotiythIJ7SFFJ/wBw9CB4VktppAfcA0zTbmkGmnQ/EgOOtzqkKjmkkE/6k+VZZlcTHqI3D8G+S5VWIZQ5BWJi2pFjoZHA+lUNLtVqHI+t1cdnnl7WwUL9lakkagOG3K4NZjH4pbbwaQtxYOYJXIylSBKkgxJIHKn+JdW320SU/iEz3KHEcfOhdn4Q4nEhxTaW20BXVpTMZinKTwFieZIG4VrFRadmkNLTsBQ46bFZ8hRiEL3qnyphtHZpQQQLSPW3xoVSYrNmTM90j22MNkEKUV5jaNExx7/Ss670vWdEHxUB7hRHTlhfWJXcICAmYJAVmUTJGmqdayk/m99dOOEXG2d2LFBxTY5c6QuK3AeZ9ZoRe0HVTKjHK0eVAB3h7vjRGGwDzn922tXOCR56VppijaoR8FKlSSSZPn614JKh/MmtFhehr6hLiktJ3yZPkLetOsBgMJhCFT1ro0J0B5DQepqXkiuNyJZo8R3fwM9l4f7Ngg0U/tXFZ1cQLWPgAPE0mLIPtR5e7y9abI283OYoKlaXEADgJ0FLlLBVMRJJgAHfxtUQbtth0+q25IE/q9r8KfWvqYT3+vyr6tLOqgpLM9nLKpm0SQZ0tGvHnwqbTgkEIJOUjWSSAZ0TJHpbzEWmJEKSuII7t0bjqSOQ1qaGyE9qLzckAKINymI4jQcKRVF6XREX7INzAA4TME3tryqpSjqjVQmJgDTtEC24iDfSpIcAVqd97QQbCNIi2m6b1Z1iSQJFo4yI0uOZooPJTkVYWVcgiSYNgoBNgrdaeFRSmDJWQLXSgGZUOK91XpSqAArSZhdo+6DeZ1FQZaWqSEkAbgJi8QYmxvc0qBsESCcxS4pdoALYQQAJtCjFuQr3ORGpJFiTOmoPER3br2qDiCpeVJCYMwTEk7gLTJGkUVkUm0ZtMxBCiD6ngOXjQhsg+gaZzE2JiIkwVAJJ8uO/Sh0JJuZTuEEciSZjcTRiUkjeU75FhYeV4tPAVDq7AEATJE8u6/Dd8ZdCsATIMQQDqTwjTWY5VYpqASItySSCCQLFPI6UWogwAJncBJM2t67vOvPsqpUkoUAJBJMwRrutwvRQWKHMOCOzmudSYkaE2oZ3CkQCBpPCxMwePhyp3kSBvBsLQRFuHONx08a+WzNykSO62gmwF+f5qBUZ0sHLYgxECAdbnluHOgn24lVtN0DgBbvrUO4UGw52yj6Jmg3cJEA+Ue/fTsVAXRzHFh5pz8CwSOKTIUBx7JIFbfai2Gg4ppKMvWLcQrLc5wMxnUixjlArC4lspM8OA01t3b92tPej+0miA2+cokFtw3CCD7KxoBz8DVpktUHYDGuJ2crF/wCI27mnSUleQgxxSIJqPSDYwxzQxmFKUuKSOtCrZk7l6GFWg90cJfqwvWM4phRSStCVAoiCc05huk5ge+sninRg2lMNuFS1ZhqJQlftBUWE3MSbmaZIhfWC4Y0kgdyQAPQVLZWMDWISs2SZSongoWPdIFCoIuToLfQmhcSvWPSpatUEo6lTOn4baCDooR50xbcQrRQ864q28tPsqI7jRjW1X0/4ivGFVzvC/DON9I/DOztIIukxRrbalapQrvSK4w10kxKfvJPhHuNGI6Z4lMX9VD491LtSRP8AGkdnw2HIMpQ2DyH6VHEYPNfq0jmCa5K3/SBiR/8Ar5iiE/0kYobvMj4pp9uXoOxL0b53Z2unvrNbUwuDaP7Rtkq32A86y+0enGLdGUKCQeGvoBWbdUpRzKUVE6k3ojil+CodNK7bo2/9d4Jv2GmgeISCfRNCYnporRCY8An5msgEValvl9d9adteTZdPHl7jV7bjrhur4nzNfMvyZN+/50uQ0aNaZP8AOqUUuDaMVHhDNhy9vnRzRAoFjCqid1wRNx3jhRrbfG3n60GgTI4nyPyr6o5Dx/019QAcGyQez2SSU3O/vIKvOo9gaACDNkhMEm88Ytv42q1SQpUSRkVlkWgzEi+vM3qJEb57IVJ1gyeOsHeTekMpUvMpMCTrpEngNQfAAGiMOsgZYynW3ZNjvAi4nwirCiIO7TXh4RVK1hIgzYgWvz5T+tMCSERBDcFJJsAYnXfczbQ16rFFYhRVe0SRuUY7uWlSKYBv7JiIkGSNbjjVMApPZBJIAOkTJtHcfOjZg9ixZUTqd5sdCfEXmx9xqhwA3kgRv89w+pq9YiQd6otxEcd16g86o2ERukT9XM76XAbsrS4rRMQbnLAgk2B0OhiJ3cqmEuDsnNlmcpkSoRIKbQe6/OpiQOPMzPO2nCq3UmBmIKSTaN/H0oodnqmzwEQTwJ3i+h1Hfc191KlDUERftSePA+/0qKUZb23Ae/TSrW2jkzhUWO4TAU0I/wBY8iN9AfgilmItA1nXcL7q8SUgACJvEfO3l9CpLsomE+RuLa9q/hFTDns2AUM0kb72EakW3nfSsKKVgiCO61r9+orxaQR7IHEzMn8Xf8qvcclUJsI/CO7neJ0ioFkgznPOw11Bj4UWFAa8ODIi38/jSnEbMWCVNkEbwd991q0RFr3A1Gl5j48qtSzmNrRz7+VNOgcTFrxSkdkhaeQUQPfEUIp6eQrdJSFJuNTHxju5UOvZTRJ7AsJ8/jVaiNJjFPbk1QWlKvH1zrbN7JbKgAkCZPdF/hVa9mokpSNBMka+HfvmiwoyAwp9/pUjhuPOe8HdxrUJwIGaACMtwee8Wsba686DGC3mLmPGJmKLChIlnl3W9+tRyfrT1WAmIgGcvvvpyoXqAdLQJ9xosKFwaEEAX47xxtpevA0dANd3dqKaIwtrm5Pw/SicNgAtM29kzI4Ddzv4Um6GlYh6s/X6+FWowpIPEbjaPq9NvsiRzudfrl7qLOGISJg9kqHIX4AXsbaXp2KhKjBKoprAcrU1VhDe+/1O/SpARpqACJ03T8KVjoBbwlxblGp/WiuqSALAd0eNvH0ogAZtIFxAuLJneNOXuqxaCidJE8CLciL0h1RU03NiY3kkx6z8atUYibbtK8Sg7jvHryivAqbHu93pQB7A/L6V9Us3f519QB//2Q==" },
                    { 2, "Yes", 2, "System", new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4232), new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4257), "Nissan Versa", "No", 60.0, 5, "Compact Car", "System", "Url" },
                    { 3, "Yes", 3, "System", new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4264), new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4267), "Toyota Corolla", "Yes", 75.0, 5, "MidSize Car", "System", "Url" },
                    { 5, "Yes", 4, "System", new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 2, 9, 9, 1, 17, 766, DateTimeKind.Local).AddTicks(4280), "Chevy Malibu", "Yes", 85.0, 5, "Full Size Car", "System", "Url" }
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
                name: "IX_PackageBookings_PackageId",
                table: "PackageBookings",
                column: "PackageId");

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
                name: "PackageBookings");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "VehicleBooking");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
