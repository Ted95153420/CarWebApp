using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPriceComparison.Migrations
{
    /// <inheritdoc />
    public partial class CountrySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName" },
                values: new object[] { 1, "Canada" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
