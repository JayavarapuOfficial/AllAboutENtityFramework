using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class noSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Chicago", "Pub 1 Jimmy" },
                    { 2, "NewYork", "Pub 2 John" },
                    { 3, "Hawaii", "Pub 3 Ben" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ISBN", "Price", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "123B12", 10.99m, 1, "Spider Without Duty" },
                    { 2, "1212BC1212", 11.99m, 2, "Fortune of time" },
                    { 3, "77652", 20.99m, 2, "Fake Sunday" },
                    { 4, "CC12B12", 25.99m, 1, "Cookie Jar" },
                    { 5, "90392B33", 40.99m, 1, "Cloudy Forest" }
                });
        }
    }
}
