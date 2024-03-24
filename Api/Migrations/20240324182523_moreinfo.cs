using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class moreinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Houses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Houses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "Country", "ZipCode" },
                values: new object[] { "1212 Valley of Kings Drive", "Dallas", "United States", "75055" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "Country", "ZipCode" },
                values: new object[] { "7855 Forks Road", "Frisco", "United States", "75052" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "Country", "ZipCode" },
                values: new object[] { "568 Grote Hof Street", "Plano", "United States", "75002" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "Country", "ZipCode" },
                values: new object[] { "321 Meel Kade Road", "McKinney", "United States", "75075" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "Country", "ZipCode" },
                values: new object[] { "123 Main Street", "Frisco", "United States", "75052" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Photo", "Price", "ZipCode" },
                values: new object[,]
                {
                    { 6, "1234 Main Street", "McKinney", "United States", "This stunning two-story home features modern amenities and a spacious backyard perfect for entertaining guests.", null, 420000, "75070" },
                    { 7, "5678 Elm Avenue", "Dallas", "United States", "A charming bungalow with a cozy fireplace and newly renovated kitchen, located in the heart of Dallas.", null, 375000, "75201" },
                    { 8, "9101 Maple Lane", "Frisco", "United States", "Experience luxury living in this spacious condominium with breathtaking views of the city skyline.", null, 550000, "75034" },
                    { 9, "2468 Oak Street", "McKinney", "United States", "A cozy cottage nestled in a quiet neighborhood, featuring a beautiful garden and outdoor patio.", null, 320000, "75071" },
                    { 10, "13579 Cedar Road", "Dallas", "United States", "This modern loft-style apartment boasts high ceilings, large windows, and easy access to downtown attractions.", null, 480000, "75202" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Country" },
                values: new object[] { "12 Valley of Kings, Geneva", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Country" },
                values: new object[] { "89 Road of Forks, Bern", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Country" },
                values: new object[] { "Grote Hof 12, Amsterdam", "The Netherlands" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Country" },
                values: new object[] { "Meel Kade 321, The Hague", "The Netherlands" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Country" },
                values: new object[] { "Oude Gracht 32, Utrecht", "The Netherlands" });
        }
    }
}
