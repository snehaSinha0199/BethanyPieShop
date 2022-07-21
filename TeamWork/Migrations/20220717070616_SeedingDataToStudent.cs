using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamWork.Migrations
{
    public partial class SeedingDataToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Age", "FirstName", "Gender", "LastName", "TeamName" },
                values: new object[] { 1, 22, "Vaibhav", "M", "Bhatnagar", "D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);
        }
    }
}
