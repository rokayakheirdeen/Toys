using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Toys.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ADDMessageRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageRequests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 5, 31, 3, 17, 13, 258, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 5, 31, 3, 17, 13, 258, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.InsertData(
                table: "MessageRequests",
                columns: new[] { "Id", "Email", "Message", "Name", "Subject" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Can you provide more details about the dolls?", "Alice Johnson", "Inquiry about dolls" },
                    { 2, "bob.smith@example.com", "Do you have puzzles suitable for children aged 5?", "Bob Smith", "Puzzle request" },
                    { 3, "charlie.brown@example.com", "Are there any discounts on action figures?", "Charlie Brown", "Action figures" },
                    { 4, "diana.prince@example.com", "How long does shipping usually take?", "Diana Prince", "Shipping inquiry" },
                    { 5, "eve.adams@example.com", "What is your return policy?", "Eve Adams", "Return policy" },
                    { 6, "frank.white@example.com", "Can you update me on the status of my order?", "Frank White", "Order status" },
                    { 7, "grace.lee@example.com", "Do you offer discounts for bulk orders?", "Grace Lee", "Bulk order" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageRequests");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2024, 5, 31, 2, 17, 30, 503, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2024, 5, 31, 2, 17, 30, 503, DateTimeKind.Local).AddTicks(9508));
        }
    }
}
