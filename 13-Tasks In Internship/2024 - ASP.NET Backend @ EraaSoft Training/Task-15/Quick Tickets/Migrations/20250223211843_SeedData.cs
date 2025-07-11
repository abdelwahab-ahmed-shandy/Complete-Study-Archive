using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Quick_Tickets.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "actors",
                columns: new[] { "Id", "Bio", "FirstName", "LastName", "News", "ProfilePicture" },
                values: new object[,]
                {
                    { 1, "Main character in Naruto", "Naruto", "Uzumaki", "Became Hokage", "naruto.png" },
                    { 2, "Main character in Dragon Ball", "Goku", "Son", "Defeated Jiren", "goku.png" },
                    { 3, "Hollywood action star", "Keanu", "Reeves", "John Wick star", "keanu.png" },
                    { 4, "Horror actress", "Vera", "Farmiga", "The Conjuring series star", "vera.png" }
                });

            migrationBuilder.InsertData(
                table: "cinemas",
                columns: new[] { "Id", "Address", "CinemaLogo", "CinemaPhonto", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Downtown", "cinema_max.png", "1.png", "Best action movies", "Cinema Max" },
                    { 2, "Main Street", "horror_hub.png", "2.png", "Scariest horror movies", "Horror Hub" },
                    { 3, "Tokyo Avenue", "anime_world.png", "3.png", "Top anime movies", "Anime World" }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "CategoryId", "CinemaId", "Description", "EndDate", "ImgUrl", "MovieStatus", "Name", "Price", "StartDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, 1, 3, "A great anime movie", new DateTime(2025, 3, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4673), "naruto.jpg", 1, "Naruto: The Last", 12.99, new DateTime(2025, 2, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4618), "trailer_naruto.mp4" },
                    { 2, 2, 1, "Best action-packed movie", new DateTime(2025, 3, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4684), "johnwick.jpg", 1, "John Wick", 15.99, new DateTime(2025, 2, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4682), "trailer_johnwick.mp4" },
                    { 3, 3, 2, "A terrifying horror movie", new DateTime(2025, 3, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4691), "conjuring.jpg", 1, "The Conjuring", 10.99, new DateTime(2025, 2, 23, 23, 18, 42, 796, DateTimeKind.Local).AddTicks(4689), "trailer_conjuring.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cinemas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
