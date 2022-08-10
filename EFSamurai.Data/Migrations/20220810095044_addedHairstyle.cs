using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSamurai.Data.Migrations
{
    public partial class addedHairstyle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hairstyle",
                table: "Samurais",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hairstyle",
                table: "Samurais");
        }
    }
}
