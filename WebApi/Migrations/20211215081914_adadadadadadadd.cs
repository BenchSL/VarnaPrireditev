using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class adadadadadadadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdInbbox",
                table: "Inbox",
                newName: "IdInbox");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdInbox",
                table: "Inbox",
                newName: "IdInbbox");
        }
    }
}
