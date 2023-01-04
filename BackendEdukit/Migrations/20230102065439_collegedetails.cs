using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendEdukit.Migrations
{
    public partial class collegedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FutureCourseid",
                table: "tblcollege",
                newName: "futureCourseid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "futureCourseid",
                table: "tblcollege",
                newName: "FutureCourseid");
        }
    }
}
