using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "ProductId", "Price", "Quantity", "TotalItemsPrice" },
                values: new object[,]
                {
                    { 1, 1, 400.39999999999998, 1, 50000.5 },
                    { 2, 2, 600.39999999999998, 3, 70000.5 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6834), new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6838), new DateTime(2025, 1, 25, 4, 21, 36, 601, DateTimeKind.Local).AddTicks(6837) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderItemId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderItemId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(5037), new DateTime(2025, 1, 25, 4, 20, 57, 924, DateTimeKind.Local).AddTicks(5036) });
        }
    }
}
