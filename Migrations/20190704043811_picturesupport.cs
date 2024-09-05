using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class PictureSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Picture_Vehicles_VehicleId",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "VehiclePictures");

            migrationBuilder.RenameIndex(
                name: "IX_Picture_VehicleId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePictures_Vehicles_VehicleId",
                table: "VehiclePictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiclePictures",
                table: "VehiclePictures");

            migrationBuilder.RenameTable(
                name: "VehiclePictures",
                newName: "Picture");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclePictures_VehicleId",
                table: "Picture",
                newName: "IX_Picture_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_Vehicles_VehicleId",
                table: "Picture",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
