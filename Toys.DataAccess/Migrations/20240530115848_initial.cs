using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Toys.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Title" },
                values: new object[,]
                {
                    { 1, "1", "Doll" },
                    { 2, "2", "Puzzle" },
                    { 3, "3", "Action" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "ListPrice", "Manufacturer", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[,]
                {
                    { 1, 3, "A cool action figure hero that kids love to play with.", "", 15.0, "Toy Corp", 13.0, 10.0, 12.0, "TF123456", "Action Figure Hero" },
                    { 2, 1, "A set of colorful building blocks to spark creativity.", "", 40.0, "Block Masters", 35.0, 25.0, 30.0, "BB654321", "Building Blocks Set" },
                    { 3, 1, "A fast and fun remote control car for racing.", "", 60.0, "Speed Toys", 55.0, 45.0, 50.0, "RC987654", "Remote Control Car" },
                    { 4, 2, "A soft and cuddly teddy bear perfect for hugs.", "", 25.0, "Soft Toys Co.", 22.0, 18.0, 20.0, "TB112233", "Plush Teddy Bear" },
                    { 5, 2, "An educational puzzle that helps kids learn and have fun.", "", 20.0, "Brainy Kids", 18.0, 14.0, 16.0, "PUZ334455", "Educational Puzzle" },
                    { 6, 1, "A beautiful dollhouse set with furniture and dolls.", "", 80.0, "Dreamland", 75.0, 65.0, 70.0, "DH445566", "Dollhouse Set" },
                    { 7, 2, "An advanced set of building blocks to inspire creativity.", "", 50.0, "Block Innovations", 45.0, 35.0, 40.0, "BB789012", "Building Blocks Deluxe Set" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
