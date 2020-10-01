using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class itemlistitem9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemListItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    ItemListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemListItems", x => new { x.ItemId, x.ItemListId });
                    table.ForeignKey(
                        name: "FK_ItemListItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemListItems_ItemLists_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "ItemLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItems_ItemListId",
                table: "ItemListItems",
                column: "ItemListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemListItems");
        }
    }
}
