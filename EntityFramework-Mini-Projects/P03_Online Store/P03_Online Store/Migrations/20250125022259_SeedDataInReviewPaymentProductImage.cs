using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P03_Online_Store.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInReviewPaymentProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "OrderId", "PaymentMethod", "TransactionDate" },
                values: new object[,]
                {
                    { 1, 1.0, 1, "Credit Card", new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(8072) },
                    { 2, 2.0, 2, "Chach Money", new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(8074) }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ImageId", "ImageOrder", "ImageURL", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, "https://example.com/images/laptop.jpg", 1 },
                    { 2, 2, "https://example.com/images/phone.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "CustomerId", "ProductId", "Rating", "ReviewDate", "ReviewText" },
                values: new object[,]
                {
                    { 1, 1, 1, 5.0, new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(8052), "This is a great product! Highly recommended." },
                    { 2, 2, 2, 4.0, new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(8056), "This is a good phone! Highly recommended." }
                });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 1,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7957), new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "ShippingId",
                keyValue: 2,
                columns: new[] { "ActualDeliveryDate", "EstimatedDeliveryDate" },
                values: new object[] { new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7961), new DateTime(2025, 1, 25, 4, 22, 58, 973, DateTimeKind.Local).AddTicks(7960) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

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
    }
}
