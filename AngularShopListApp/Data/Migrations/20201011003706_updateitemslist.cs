using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class updateitemslist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsListItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsLists",
                table: "ItemsLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "ItemsLists",
                newName: "ItemsList");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsList",
                table: "ItemsList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ItemsListItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    ItemsListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsListItem", x => new { x.ItemId, x.ItemsListId });
                    table.ForeignKey(
                        name: "FK_ItemsListItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsListItem_ItemsList_ItemsListId",
                        column: x => x.ItemsListId,
                        principalTable: "ItemsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsListItem_ItemsListId",
                table: "ItemsListItem",
                column: "ItemsListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsListItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsList",
                table: "ItemsList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "ItemsList",
                newName: "ItemsLists");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsLists",
                table: "ItemsLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ItemsListItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemsListId = table.Column<int>(type: "int", nullable: false)
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
    }
}
