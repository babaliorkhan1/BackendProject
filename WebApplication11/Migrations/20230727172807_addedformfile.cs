using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication11.Migrations
{
    public partial class addedformfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "courses");
        }
    }
}
