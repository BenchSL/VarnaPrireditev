using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class sgdm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormCard");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormCard",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEducation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });
        }
    }
}
