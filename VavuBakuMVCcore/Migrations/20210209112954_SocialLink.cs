using Microsoft.EntityFrameworkCore.Migrations;

namespace VavuBakuMVCcore.Migrations
{
    public partial class SocialLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "SocialMedias",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "SocialMedias");
        }
    }
}
