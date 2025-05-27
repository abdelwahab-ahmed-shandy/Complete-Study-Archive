using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInProductCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductCatalogs",
                columns: new[] { "ProductId", "CategoryId", "Description", "Price", "ProductName", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, 1, "Dell", 999.99000000000001, "Laptop", 50 },
                    { 2, 2, "Iphone12", 1999.99, "Smartphone", 90 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCatalogs",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCatalogs",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2246), new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2250), new DateTime(2025, 1, 25, 4, 20, 5, 967, DateTimeKind.Local).AddTicks(2249) });
        }
    }
}
