using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "DurationInMinutes", "IsDeleted", "Name", "Price", "ProviderId" },
                values: new object[,]
                {
                    { 1, "Basic dental examination", 0, false, "Dental Check", 200m, "provider1" },
                    { 2, "Men haircut", 0, false, "Haircut", 100m, "provider1" }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "EndTime", "IsBooked", "ServiceId", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(2026, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2026, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(2026, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
