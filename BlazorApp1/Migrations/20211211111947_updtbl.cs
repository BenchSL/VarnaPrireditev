using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class updtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Forms");
        }
    }
}
