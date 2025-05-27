using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P02_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataStudentCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 2 });

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 18, 21, 732, DateTimeKind.Local).AddTicks(6005));
        }
    }
}
