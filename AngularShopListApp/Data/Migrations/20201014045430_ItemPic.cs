using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class ItemPic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pic",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pic",
                table: "Item");
        }
    }
}
