using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularShopListApp.Data.Migrations
{
    public partial class practice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Barcode = table.Column<string>(nullable: true),
                    createdDate = table.Column<DateTime>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
