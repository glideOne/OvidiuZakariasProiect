using Microsoft.EntityFrameworkCore.Migrations;

namespace OvidiuZakariasProiect.Migrations
{
    public partial class GenreNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Origins",
                table: "Genre",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Genre",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Origins",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Genre");
        }
    }
}
