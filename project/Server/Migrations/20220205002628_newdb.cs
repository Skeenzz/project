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
                    LeavingFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "TypeOfVehicles",
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
                    table.PrimaryKey("PK_TypeOfVehicles", x => x.Id);
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
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Passenger = table.Column<int>(type: "int", nullable: false),
                    LeavingFromId = table.Column<int>(type: "int", nullable: false),
                    GoingToId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    Departing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returning = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Flights_GoingToId",
                        column: x => x.GoingToId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Flights_LeavingFromId",
                        column: x => x.LeavingFromId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Flights_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Passenger = table.Column<int>(type: "int", nullable: false),
                    luggage = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfVehicleId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetails_TypeOfVehicles_PriceId",
                        column: x => x.PriceId,
                        principalTable: "TypeOfVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_TypeOfVehicles_TypeOfVehicleId",
                        column: x => x.TypeOfVehicleId,
                        principalTable: "TypeOfVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "2e60a09c-9f70-43d2-94ff-0fc00073d455", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ab21869d-5496-4409-a202-3c766d4ec46d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "736d93c8-0b41-41d3-99dc-9ee5dc235c29", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEB55BrFFeLNG4lh04mqUAiD4RHY0PzqK6ktivgrFtOSQP9zgBqFN4+J8JkW0XKgpMw==", null, false, "5e5e9e67-99cd-44de-a484-85bf739d9d05", false, "Admin" });

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
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "GoingTo", "LeavingFrom", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(455), "japan", "Singapore", 780.0, "System" },
                    { 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(465), "USA", "Singapore", 1780.0, "System" },
                    { 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(469), new DateTime(2022, 2, 5, 8, 26, 27, 318, DateTimeKind.Local).AddTicks(470), "china", "Singapore", 580.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfVehicles",
                columns: new[] { "Id", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Price", "Seat", "TypeOfVehicles", "UpdatedBy" },
                values: new object[,]
                {
                    { 19, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7698), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7700), "Mercedes Benz S Class", 30.300000000000001, 5, "Large Executive Luxury Car", "System" },
                    { 20, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7703), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7705), "Porsche Panamera", 30.300000000000001, 5, "Large Executive Luxury Car", "System" },
                    { 21, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7709), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7710), "Nissan Kicks", 30.300000000000001, 5, "Compact SUV", "System" },
                    { 22, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7714), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7716), "Nissan Rogue", 30.300000000000001, 5, "MidSize SUV", "System" },
                    { 23, 5, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7722), "Ford Edge ", 30.300000000000001, 5, "Standard SUV", "System" },
                    { 24, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7725), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7727), "Chevrolet Tahoe ", 30.300000000000001, 7, "Full Size SUV", "System" },
                    { 25, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7733), "Infiniti QX80", 30.300000000000001, 7, "Luxury SUV", "System" },
                    { 29, 7, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7754), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7756), "Chevy Suburban", 30.300000000000001, 8, "Premium SUV", "System" },
                    { 27, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7743), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7745), "Volkswagen Atlas", 30.300000000000001, 7, "Premium Crossover", "System" },
                    { 28, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7748), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7750), "Mercedes Benz GLE", 30.300000000000001, 5, "Luxury Elite SUV", "System" },
                    { 18, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7695), "BMW 7 Series", 30.300000000000001, 5, "Large Executive Luxury Car", "System" },
                    { 30, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7761), "BMW X3 ", 30.300000000000001, 5, "Premium Elite SUV", "System" },
                    { 31, 5, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7767), "Chrysler Pacifica ", 30.300000000000001, 7, "7 Passenger Minivan", "System" },
                    { 32, 5, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7772), "Toyota Sienna", 30.300000000000001, 8, "8 Passenger Minivan", "System" },
                    { 26, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7737), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7739), "Cadillac XT4", 30.300000000000001, 5, "Standard Elite SUV", "System" },
                    { 17, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7687), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7689), "Mercedes AMG E53", 30.300000000000001, 5, "Executive Luxury Car", "System" },
                    { 13, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7666), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7668), "BMW 5 Series ", 30.300000000000001, 5, "Premium Elite Car", "System" },
                    { 15, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7676), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7678), "Chrysler 300", 30.300000000000001, 5, "Luxury Car", "System" },
                    { 1, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 311, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(5534), "Mitsubishi Mirage", 50.5, 4, "Economy Car", "System" },
                    { 2, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7601), "Nissan Versa", 40.399999999999999, 5, "Compact Car", "System" },
                    { 3, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7607), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7610), "Toyota Corolla", 45.130000000000003, 5, "MidSize Car", "System" },
                    { 4, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7615), "Volkswagen Jetta", 30.300000000000001, 5, "Standard Car", "System" },
                    { 5, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7621), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7623), "Chevy Malibu", 30.300000000000001, 5, "Full Size Car", "System" },
                    { 6, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7628), "Ford Mustang Convertible", 30.300000000000001, 4, "Convertible Car", "System" },
                    { 16, 3, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7682), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7684), "Maserati Ghibli", 30.300000000000001, 5, "Executive Luxury Car", "System" },
                    { 7, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7631), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7633), "Dodge Challenger", 30.300000000000001, 4, "Sporty Car", "System" },
                    { 9, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7645), " Audi A5 Sportback", 30.300000000000001, 5, "Full Size Elite Car", "System" },
                    { 10, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7650), "BMW 228i Gran Coupe", 30.300000000000001, 5, "Standard Elite Car", "System" },
                    { 11, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7654), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7656), "Tesla Model S", 30.300000000000001, 5, "Luxury Elite Electric Car", "System" },
                    { 12, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7659), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7661), "Chevrolet Impala", 30.300000000000001, 5, "Premium Special Car", "System" },
                    { 33, 12, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7776), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7778), "Ford Transit Wagon", 30.300000000000001, 12, "12 Passenger Van", "System" },
                    { 14, 4, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7671), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7673), "Nissan Maxima ", 30.300000000000001, 5, "Premium Car", "System" },
                    { 8, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7639), "INFINITI Q50", 30.300000000000001, 5, "Full Size Elite Car", "System" },
                    { 34, 2, "System", new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7781), new DateTime(2022, 2, 5, 8, 26, 27, 314, DateTimeKind.Local).AddTicks(7783), "Ford Transit Wagon", 30.300000000000001, 15, "15 Passenger Van", "System" }
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
                name: "IX_Booking_GoingToId",
                table: "Booking",
                column: "GoingToId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_LeavingFromId",
                table: "Booking",
                column: "LeavingFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PriceId",
                table: "Booking",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_PriceId",
                table: "BookingDetails",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_TypeOfVehicleId",
                table: "BookingDetails",
                column: "TypeOfVehicleId");

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
                name: "Booking");

            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "TypeOfVehicles");
        }
    }
}
