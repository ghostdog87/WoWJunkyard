using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Migrations
{
    public partial class added_dungeons_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dungeons_Characters_CharacterId",
                table: "Dungeons");

            migrationBuilder.DropColumn(
                name: "AccomplishedLevel",
                table: "Dungeons");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dungeons",
                newName: "DungeonName");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Dungeons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompletedTimestamp",
                table: "Dungeons",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Duration",
                table: "Dungeons",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompletedWithinTime",
                table: "Dungeons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "KeystoneLevel",
                table: "Dungeons",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Dungeons_Characters_CharacterId",
                table: "Dungeons",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dungeons_Characters_CharacterId",
                table: "Dungeons");

            migrationBuilder.DropColumn(
                name: "CompletedTimestamp",
                table: "Dungeons");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Dungeons");

            migrationBuilder.DropColumn(
                name: "IsCompletedWithinTime",
                table: "Dungeons");

            migrationBuilder.DropColumn(
                name: "KeystoneLevel",
                table: "Dungeons");

            migrationBuilder.RenameColumn(
                name: "DungeonName",
                table: "Dungeons",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Dungeons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AccomplishedLevel",
                table: "Dungeons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Dungeons_Characters_CharacterId",
                table: "Dungeons",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
