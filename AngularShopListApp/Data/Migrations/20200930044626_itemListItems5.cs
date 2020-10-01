using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class itemListItems5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemListItemsModel_Items_ItemId",
                table: "ItemListItemsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemListItemsModel",
                table: "ItemListItemsModel");

            migrationBuilder.DropIndex(
                name: "IX_ItemListItemsModel_ItemId",
                table: "ItemListItemsModel");

            migrationBuilder.DropIndex(
                name: "IX_ItemListItemsModel_ItemListId",
                table: "ItemListItemsModel");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemListItemsModel");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemListItemsModel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
                //.OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemListItemsModel",
                table: "ItemListItemsModel",
                columns: new[] { "ItemListId", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_Id",
                table: "ItemListItemsModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListItemsModel_Items_Id",
                table: "ItemListItemsModel",
                column: "Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemListItemsModel_Items_Id",
                table: "ItemListItemsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemListItemsModel",
                table: "ItemListItemsModel");

            migrationBuilder.DropIndex(
                name: "IX_ItemListItemsModel_Id",
                table: "ItemListItemsModel");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemListItemsModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(int));
                //.Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemListItemsModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemListItemsModel",
                table: "ItemListItemsModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_ItemId",
                table: "ItemListItemsModel",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemListItemsModel_ItemListId",
                table: "ItemListItemsModel",
                column: "ItemListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListItemsModel_Items_ItemId",
                table: "ItemListItemsModel",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
