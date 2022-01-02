using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class addLenderAddItemNameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "Id");
        }
    }
}
