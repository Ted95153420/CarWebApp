using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPriceComparison.Migrations
{
    public partial class Country_city_Dealership : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true),
                    CountryForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryForeignKey",
                        column: x => x.CountryForeignKey,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DealerName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    WebAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CityForeignKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dealer_City_CityForeignKey",
                        column: x => x.CityForeignKey,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityFuelEconomy = table.Column<float>(nullable: false),
                    HighwayFuelEconomy = table.Column<float>(nullable: false),
                    ListPrice = table.Column<float>(nullable: false),
                    SoldPrice = table.Column<float>(nullable: false),
                    VehicleMakeId = table.Column<int>(nullable: true),
                    MakeForeignKey = table.Column<int>(nullable: false),
                    VehicleModelId = table.Column<int>(nullable: true),
                    ModelForeignKey = table.Column<int>(nullable: false),
                    DealerId = table.Column<int>(nullable: true),
                    DealerForeignKey = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMakes_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalTable: "VehicleMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryForeignKey",
                table: "City",
                column: "CountryForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_CityForeignKey",
                table: "Dealer",
                column: "CityForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DealerId",
                table: "Vehicle",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleModelId",
                table: "Vehicle",
                column: "VehicleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
