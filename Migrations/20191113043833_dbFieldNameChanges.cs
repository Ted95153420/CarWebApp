using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class dbFieldNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePictures_Vehicles_VehicleId",
                table: "VehiclePictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiclePictures",
                table: "VehiclePictures");

            migrationBuilder.RenameTable(
                name: "VehiclePictures",
                newName: "Pictures");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclePictures_VehicleId",
                table: "Pictures",
                newName: "IX_Pictures_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Vehicles_VehicleId",
                table: "Pictures",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Vehicles_VehicleId",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "VehiclePictures");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_VehicleId",
                table: "VehiclePictures",
                newName: "IX_VehiclePictures_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiclePictures",
                table: "VehiclePictures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePictures_Vehicles_VehicleId",
                table: "VehiclePictures",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
