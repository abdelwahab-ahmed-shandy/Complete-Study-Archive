using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7050), 0, 600.5 },
                    { 2, 2, new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7092), 1, 300.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);
        }
    }
}
