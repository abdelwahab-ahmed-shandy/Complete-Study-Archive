using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoItem.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toDoLists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "toDoLists",
                columns: new[] { "Id", "DeadLine", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 19, 20, 58, 59, 804, DateTimeKind.Local).AddTicks(4050), "Practice basic and advanced C# concepts", "Learn C#" },
                    { 2, new DateTime(2025, 2, 26, 20, 58, 59, 804, DateTimeKind.Local).AddTicks(4134), "Create a To-Do List web app using ASP.NET Core", "Build ASP.NET App" },
                    { 3, new DateTime(2025, 3, 5, 20, 58, 59, 804, DateTimeKind.Local).AddTicks(4140), "Connect the To-Do List app with a SQL database", "Database Integration" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toDoLists");
        }
    }
}
