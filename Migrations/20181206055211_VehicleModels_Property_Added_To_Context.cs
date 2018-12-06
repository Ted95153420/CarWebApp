using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class VehicleModels_Property_Added_To_Context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModel_VehicleMakes_VehicleMakeForeignKey",
                table: "VehicleModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleModel",
                table: "VehicleModel");

            migrationBuilder.RenameTable(
                name: "VehicleModel",
                newName: "VehicleModels");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleModel_VehicleMakeForeignKey",
                table: "VehicleModels",
                newName: "IX_VehicleModels_VehicleMakeForeignKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_VehicleMakes_VehicleMakeForeignKey",
                table: "VehicleModels",
                column: "VehicleMakeForeignKey",
                principalTable: "VehicleMakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_VehicleMakes_VehicleMakeForeignKey",
                table: "VehicleModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleModels",
                table: "VehicleModels");

            migrationBuilder.RenameTable(
                name: "VehicleModels",
                newName: "VehicleModel");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleModels_VehicleMakeForeignKey",
                table: "VehicleModel",
                newName: "IX_VehicleModel_VehicleMakeForeignKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleModel",
                table: "VehicleModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModel_VehicleMakes_VehicleMakeForeignKey",
                table: "VehicleModel",
                column: "VehicleMakeForeignKey",
                principalTable: "VehicleMakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
