using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Migrations
{
    public partial class initial_create_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemInfos_EquippedItems_EquippedItemId",
                table: "ItemInfos");

            migrationBuilder.DropIndex(
                name: "IX_ItemInfos_EquippedItemId",
                table: "ItemInfos");

            migrationBuilder.CreateIndex(
                name: "IX_EquippedItems_ItemId",
                table: "EquippedItems",
                column: "ItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EquippedItems_ItemInfos_ItemId",
                table: "EquippedItems",
                column: "ItemId",
                principalTable: "ItemInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquippedItems_ItemInfos_ItemId",
                table: "EquippedItems");

            migrationBuilder.DropIndex(
                name: "IX_EquippedItems_ItemId",
                table: "EquippedItems");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInfos_EquippedItemId",
                table: "ItemInfos",
                column: "EquippedItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemInfos_EquippedItems_EquippedItemId",
                table: "ItemInfos",
                column: "EquippedItemId",
                principalTable: "EquippedItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
