using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Courses (CourseName) VALUES ('MATH 275')");
            migrationBuilder.Sql("INSERT INTO Courses (CourseName) VALUES ('MATH 211')");
            migrationBuilder.Sql("INSERT INTO Courses (CourseName) VALUES ('CHEM 209')");
            migrationBuilder.Sql("INSERT INTO Courses (CourseName) VALUES ('ENGG 200')");
            migrationBuilder.Sql("INSERT INTO Courses (CourseName) VALUES ('ENGG 233')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Courses WHERE CourseName IN ('MATH 275', 'MATH 211', 'CHEM 209', 'ENGG 200', 'ENGG 233')");
        }
    }
}
