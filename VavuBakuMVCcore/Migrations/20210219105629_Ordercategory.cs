using Microsoft.EntityFrameworkCore.Migrations;

namespace VavuBakuMVCcore.Migrations
{
    public partial class Ordercategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Foods");

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "FoodCategories",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "FoodCategories");

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Foods",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
