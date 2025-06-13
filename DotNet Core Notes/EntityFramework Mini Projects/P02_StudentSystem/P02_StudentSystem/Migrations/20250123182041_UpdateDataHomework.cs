using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P02_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataHomework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(4971), new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(4984), new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, "C++ Mini Project", 0, 1, 1, new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5277) },
                    { 2, "C# Mini Project", 1, 2, 2, new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5283) }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5217));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 1, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 1, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 19, 16, 422, DateTimeKind.Local).AddTicks(680));
        }
    }
}
