using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradDemonstration.Migrations
{
    public partial class M20230415075500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Persons",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
