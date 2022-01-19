using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class adafadafafa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameSurvey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSub = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Survey");
        }
    }
}
