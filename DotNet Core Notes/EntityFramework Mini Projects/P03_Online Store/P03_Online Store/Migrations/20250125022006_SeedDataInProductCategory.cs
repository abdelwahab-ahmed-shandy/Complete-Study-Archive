using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Laptops" },
                    { 2, "Phone" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5452), new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5456), new DateTime(2025, 1, 25, 4, 17, 6, 709, DateTimeKind.Local).AddTicks(5455) });
        }
    }
}
