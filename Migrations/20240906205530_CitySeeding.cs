using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarPriceComparison.Migrations
{
    /// <inheritdoc />
    public partial class CitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "CountryForeignKey" },
                values: new object[,]
                {
                    { 1, "Toronto", 1 },
                    { 2, "Montréal", 1 },
                    { 3, "Vancouver", 1 },
                    { 4, "Calgary", 1 },
                    { 5, "Ottowa", 1 },
                    { 6, "Edmonton", 1 },
                    { 7, "Mississauga", 1 },
                    { 8, "North York", 1 },
                    { 9, "Winnipeg", 1 },
                    { 10, "Québec City", 1 },
                    { 11, "Hamilton", 1 },
                    { 12, "Brampton", 1 },
                    { 13, "Kitchener", 1 },
                    { 14, "Surrey", 1 },
                    { 15, "Laval", 1 },
                    { 16, "Halifax", 1 },
                    { 17, "London", 1 },
                    { 18, "Victoria", 1 },
                    { 19, "Windsor", 1 },
                    { 20, "Oshowa", 1 },
                    { 21, "Gatineau", 1 },
                    { 22, "Vaughan", 1 },
                    { 23, "Longueuil", 1 },
                    { 24, "Burnaby", 1 },
                    { 25, "Ladner", 1 },
                    { 26, "Saskatoon", 1 },
                    { 27, "Barrie", 1 },
                    { 28, "Richmond", 1 },
                    { 29, "Regina", 1 },
                    { 30, "Oakville", 1 },
                    { 31, "Burlington", 1 },
                    { 32, "Greater Sudbury", 1 },
                    { 33, "Abbotsford", 1 },
                    { 34, "Saguenay", 1 },
                    { 35, "St Catherines", 1 },
                    { 36, "Sherbrooke", 1 },
                    { 37, "Lévis", 1 },
                    { 38, "Kelowna", 1 },
                    { 39, "Cambridge", 1 },
                    { 40, "Trois Rivières", 1 },
                    { 41, "Guelph", 1 },
                    { 42, "Coquitlam", 1 },
                    { 43, "Kingston", 1 },
                    { 44, "Chatham-Kent", 1 },
                    { 45, "Sydney", 1 },
                    { 46, "Delta", 1 },
                    { 47, "DartMouth", 1 },
                    { 48, "Thunder Bay", 1 },
                    { 49, "St John's", 1 },
                    { 50, "Waterloo", 1 },
                    { 51, "Terrebonne", 1 },
                    { 52, "Langley", 1 },
                    { 53, "Saint John", 1 },
                    { 54, "Pickering", 1 },
                    { 55, "Brantford", 1 },
                    { 56, "Moncton", 1 },
                    { 57, "Nanaimo", 1 },
                    { 58, "Sarnia", 1 },
                    { 59, "Niagra Falls", 1 },
                    { 60, "Saint-Laurent", 1 },
                    { 61, "Repentigny", 1 },
                    { 62, "Fort McMurray", 1 },
                    { 63, "Peterborough", 1 },
                    { 64, "Sault Ste. Marie", 1 },
                    { 65, "Kawartha Lakes", 1 },
                    { 66, "Red Deer", 1 },
                    { 67, "Saint-Jean-sur-Richelieu", 1 },
                    { 68, "Lethbridge", 1 },
                    { 69, "Maple Ridge", 1 },
                    { 70, "Brossard", 1 },
                    { 71, "Chilliwack", 1 },
                    { 72, "Kamloops", 1 },
                    { 73, "White Rock", 1 },
                    { 74, "Prince George", 1 },
                    { 75, "Medicine Hat", 1 },
                    { 76, "Norfolk County", 1 },
                    { 77, "Drummondville", 1 },
                    { 78, "New Westminster", 1 },
                    { 79, "St Albert", 1 },
                    { 80, "Sherwood Park", 1 },
                    { 81, "Saint-Jérôme", 1 },
                    { 82, "Jonquière", 1 },
                    { 83, "Granby", 1 },
                    { 84, "Fredericton", 1 },
                    { 85, "Welland", 1 },
                    { 86, "Saint-Hyacinthe", 1 },
                    { 87, "North Bay", 1 },
                    { 88, "Shawinigan", 1 },
                    { 89, "Dollard-Des Ormeaux", 1 },
                    { 90, "Belleville", 1 },
                    { 91, "Cornwall", 1 },
                    { 92, "North Vancouver", 1 },
                    { 93, "Vernon", 1 },
                    { 94, "Blainville", 1 },
                    { 95, "Haldimand County", 1 },
                    { 96, "Timmins", 1 },
                    { 97, "Châteauguay", 1 },
                    { 98, "Quinte West", 1 },
                    { 99, "Charlottetown", 1 },
                    { 100, "Rimouski", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
