using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedya.Cafe.Migrations
{
    public partial class mig_thrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Subscribes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Subscribes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
