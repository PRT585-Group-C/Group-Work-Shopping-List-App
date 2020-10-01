using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class itemListItems3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemLists",
                columns: table => new
                {
                    ItemListId = table.Column<int>(nullable: false),
                       //.Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    createdDate = table.Column<DateTime>(nullable: false),
                    createdUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLists", x => x.ItemListId);
                });

            migrationBuilder.CreateTable(
                name: "ItemListItemsModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                        //.Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: true),
                    ItemListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemListItemsModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemListItemsModel_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemListItemsModel_ItemLists_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "ItemLists",
                        principalColumn: "ItemListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_ItemId",
                table: "ItemListItemsModel",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_ItemListId",
                table: "ItemListItemsModel",
                column: "ItemListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemListItemsModel");

            migrationBuilder.DropTable(
                name: "ItemLists");
        }
    }
}
