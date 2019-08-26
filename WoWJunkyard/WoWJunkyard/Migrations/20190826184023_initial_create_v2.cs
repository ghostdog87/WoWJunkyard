using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Migrations
{
    public partial class initial_create_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemInfos",
                newName: "ItemIdNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemIdNumber",
                table: "ItemInfos",
                newName: "ItemId");
        }
    }
}
