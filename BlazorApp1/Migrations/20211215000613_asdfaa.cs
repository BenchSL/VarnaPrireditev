using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class asdfaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Inbox",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inbox",
                table: "Users");
        }
    }
}
