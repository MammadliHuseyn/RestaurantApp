using Microsoft.EntityFrameworkCore.Migrations;

namespace VavuBakuMVCcore.Migrations
{
    public partial class Icons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressIcon",
                table: "Settings",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailIcon",
                table: "Settings",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneIcon",
                table: "Settings",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressIcon",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EmailIcon",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "PhoneIcon",
                table: "Settings");
        }
    }
}
