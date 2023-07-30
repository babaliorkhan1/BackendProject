using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication11.Migrations
{
    public partial class addedCourserelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutCourseTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutCourseText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutApplyTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutApplyText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutCertificationText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutCertificationTItle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentNumbers = table.Column<int>(type: "int", nullable: false),
                    Assetments = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courseCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseCategories_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_courseCategories_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseCategories_CategoryId",
                table: "courseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_courseCategories_CourseId",
                table: "courseCategories",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseCategories");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
