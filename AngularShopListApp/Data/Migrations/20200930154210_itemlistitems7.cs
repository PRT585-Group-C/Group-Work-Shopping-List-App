using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class itemlistitems7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemListItemsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemLists",
                table: "ItemLists");

            migrationBuilder.DropColumn(
                name: "ItemListId",
                table: "ItemLists");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ItemLists",
                nullable: false,
                defaultValue: 0);
               // .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemLists",
                table: "ItemLists",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemLists",
                table: "ItemLists");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ItemLists");

            migrationBuilder.AddColumn<int>(
                name: "ItemListId",
                table: "ItemLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
                //.Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemLists",
                table: "ItemLists",
                column: "ItemListId");

            migrationBuilder.CreateTable(
                name: "ItemListItemsModel",
                columns: table => new
                {
                    ItemListId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemListItemsModel", x => new { x.ItemListId, x.Id });
                    table.ForeignKey(
                        name: "FK_ItemListItemsModel_Items_Id",
                        column: x => x.Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemListItemsModel_ItemLists_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "ItemLists",
                        principalColumn: "ItemListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_Id",
                table: "ItemListItemsModel",
                column: "Id");
        }
    }
}
