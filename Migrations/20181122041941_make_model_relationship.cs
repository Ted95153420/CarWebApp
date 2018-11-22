using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class make_model_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    VehicleMakeForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleMakes_VehicleMakeForeignKey",
                        column: x => x.VehicleMakeForeignKey,
                        principalTable: "VehicleMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleMakeForeignKey",
                table: "VehicleModel",
                column: "VehicleMakeForeignKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleModel");
        }
    }
}
