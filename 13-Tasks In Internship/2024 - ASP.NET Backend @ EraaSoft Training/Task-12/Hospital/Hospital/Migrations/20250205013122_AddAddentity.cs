using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AddAddentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, "~/assets/image/doctor/doctor1.jpg", "Dr. John Smith", "Pediatrics" },
                    { 2, "~/assets/image/doctor/doctor2.jpg", "Dr. Michael Lee", "Dermatology" },
                    { 3, "~/assets/image/doctor/doctor3.jpg", "Dr. Abdulrahaman Shandy", "Orthopedics" },
                    { 4, "~/assets/image/doctor/doctor4.jpg", "Dr. Emily Davis", "Neurology" },
                    { 5, "~/assets/image/doctor/doctor4.jpg", "Dr. Sarah Johnson", "Neurology" },
                    { 6, "~/assets/image/doctor/doctor4.jpg", "Dr. John Smith", "Neurology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
