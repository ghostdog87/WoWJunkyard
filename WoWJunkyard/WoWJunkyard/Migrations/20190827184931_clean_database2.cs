using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Migrations
{
    public partial class clean_database2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquippedItemId",
                table: "ItemInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquippedItemId",
                table: "ItemInfos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
