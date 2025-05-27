using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P02_StudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(690), new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(711), new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "C++", 0, "programmingadvices.com" },
                    { 2, 2, "C#", 2, "programmingadvices.com" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2025, 1, 23, 20, 21, 58, 108, DateTimeKind.Local).AddTicks(1032));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 23, 20, 20, 40, 752, DateTimeKind.Local).AddTicks(5283));

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
    }
}
