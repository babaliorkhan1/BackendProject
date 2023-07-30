using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication11.Migrations
{
    public partial class addedcontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
