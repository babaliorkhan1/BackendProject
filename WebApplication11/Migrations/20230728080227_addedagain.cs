using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication11.Migrations
{
    public partial class addedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutApplyText",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutApplyTitle",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutCertificationTItle",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutCertificationText",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutCourseText",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutCourseTitle",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "AboutText",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Assetments",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ClassDuration",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "StudentNumbers",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "categories",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "SkillLevel",
                table: "categories",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "AboutApplyText",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutApplyTitle",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCertificationTItle",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCertificationText",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCourseText",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCourseTitle",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutText",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Assetments",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClassDuration",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillLevel",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Start",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentNumbers",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutApplyText",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutApplyTitle",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutCertificationTItle",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutCertificationText",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutCourseText",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutCourseTitle",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "AboutText",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Assetments",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "ClassDuration",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "StudentNumbers",
                table: "courses");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "categories",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "categories",
                newName: "SkillLevel");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AboutApplyText",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutApplyTitle",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCertificationTItle",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCertificationText",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCourseText",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutCourseTitle",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutText",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Assetments",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClassDuration",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentNumbers",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
