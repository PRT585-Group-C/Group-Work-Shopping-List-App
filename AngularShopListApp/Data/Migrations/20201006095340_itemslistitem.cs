using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class itemslistitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemsListItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    ItemsListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsListItems", x => new { x.ItemId, x.ItemsListId });
                    table.ForeignKey(
                        name: "FK_ItemsListItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsListItems_ItemsLists_ItemsListId",
                        column: x => x.ItemsListId,
                        principalTable: "ItemsLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsListItems_ItemsListId",
                table: "ItemsListItems",
                column: "ItemsListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsListItems");
        }
    }
}
