using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkFest.Migrations
{
    public partial class _editShortDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "ShortDescription",
                value: "The third most popular drink overall after water and tea");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 27,
                column: "ShortDescription",
                value: "Kvass is a fermented cereal-based low alcoholic beverage.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 28,
                column: "ShortDescription",
                value: "Naturally contained or present in fruit or vegetable tissue.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "ShortDescription",
                value: "The most widely consumed alcohol and the third most popular drink overall after water and tea");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 27,
                column: "ShortDescription",
                value: "Kvass is a fermented cereal-based low alcoholic beverage with a slightly cloudy appearance, light-brown colour and sweet-sour taste");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 28,
                column: "ShortDescription",
                value: "Naturally contained in fruit or vegetable tissue. The liquid obtained from fruit or vegetables.");
        }
    }
}
