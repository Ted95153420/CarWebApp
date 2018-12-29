using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class Country_city_Dealership_Tidied_VehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Dealer_DealerId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "DealerForeignKey",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "MakeForeignKey",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ModelForeignKey",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "DealerId",
                table: "Vehicle",
                newName: "VehicleDealerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_DealerId",
                table: "Vehicle",
                newName: "IX_Vehicle_VehicleDealerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Dealer_VehicleDealerId",
                table: "Vehicle",
                column: "VehicleDealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Dealer_VehicleDealerId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleDealerId",
                table: "Vehicle",
                newName: "DealerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_VehicleDealerId",
                table: "Vehicle",
                newName: "IX_Vehicle_DealerId");

            migrationBuilder.AddColumn<int>(
                name: "DealerForeignKey",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MakeForeignKey",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelForeignKey",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Dealer_DealerId",
                table: "Vehicle",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
