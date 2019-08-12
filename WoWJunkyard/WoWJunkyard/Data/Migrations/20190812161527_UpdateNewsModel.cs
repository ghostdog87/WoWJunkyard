using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Data.Migrations
{
    public partial class UpdateNewsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "News",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
