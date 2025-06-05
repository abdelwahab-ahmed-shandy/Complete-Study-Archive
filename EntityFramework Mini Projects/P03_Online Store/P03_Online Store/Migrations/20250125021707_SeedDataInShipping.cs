using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInShipping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "ShippingId", "ActualDeliveryDate", "CarrierName", "EstimatedDeliveryDate", "OrderId", "ShippingStatus", "TrackingNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5452), "FedEx", new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5448), 1, 0, "123456789" },
                    { 2, new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5456), "DHL", new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5455), 2, 3, "987654321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 16, 34, 114, DateTimeKind.Local).AddTicks(7092));
        }
    }
}
