using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetreadyProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseNumberOfWeeks",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherFirstName",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherLastName",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseNumberOfWeeks",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TeacherFirstName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TeacherLastName",
                table: "Courses");
        }
    }
}
