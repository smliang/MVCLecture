using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLecture.Data.Migrations
{
    public partial class ChangedGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Grade");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Grade",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grade_CourseId",
                table: "Grade",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Course_CourseId",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Grade_CourseId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Grade");

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Grade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
