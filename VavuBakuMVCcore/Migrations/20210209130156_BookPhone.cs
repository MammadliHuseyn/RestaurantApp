using Microsoft.EntityFrameworkCore.Migrations;

namespace VavuBakuMVCcore.Migrations
{
    public partial class BookPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Books",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Books");
        }
    }
}
