using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Api.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "dGVzdGluZ3hAQGxtbnF3cnN0QA==", "testing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "c2FsYWRlZkBAa2Z4Y2J2QA==", "sal" });
        }
    }
}
