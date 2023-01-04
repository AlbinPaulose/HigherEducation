using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendEdukit.Migrations
{
    public partial class addedcoursetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseType",
                table: "tblcourse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseType",
                table: "tblcourse");
        }
    }
}
