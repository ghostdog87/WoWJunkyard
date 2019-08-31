using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Migrations
{
    public partial class updated_dungeon_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DungeonId",
                table: "Dungeons",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DungeonId",
                table: "Dungeons");
        }
    }
}
