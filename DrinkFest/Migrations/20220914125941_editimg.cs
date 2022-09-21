using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkFest.Migrations
{
    public partial class editimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "https://images.unsplash.com/photo-1614313511387-1436a4480ebb?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cnVtfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "https://images.unsplash.com/photo-1639834482101-5f332c3b701f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fHJ1bSUyMGFuZCUyMGNva2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60");
        }
    }
}
