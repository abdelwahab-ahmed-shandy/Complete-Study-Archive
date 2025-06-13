using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P02_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5833), new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5845), new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDay", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdelwahab Shandy", "01017417", new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5993) },
                    { 2, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anas Shandy", "902290", new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(6005) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 16, 26, 901, DateTimeKind.Local).AddTicks(9578), new DateTime(2025, 1, 23, 20, 16, 26, 901, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 16, 26, 901, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 1, 23, 20, 16, 26, 901, DateTimeKind.Local).AddTicks(9589) });
        }
    }
}
