using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Data.Migrations
{
    public partial class AddCharacterModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AzeriteEmpoweredItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeriteEmpoweredItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzeriteItems",
                columns: table => new
                {
                    AzeriteItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<long>(nullable: false),
                    AzeriteLevel = table.Column<long>(nullable: false),
                    AzeriteExperience = table.Column<long>(nullable: false),
                    AzeriteExperienceRemaining = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeriteItems", x => x.AzeriteItemId);
                });

            migrationBuilder.CreateTable(
                name: "AzeritePowers",
                columns: table => new
                {
                    AzeritePowerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<long>(nullable: false),
                    Tier = table.Column<long>(nullable: false),
                    SpellId = table.Column<long>(nullable: false),
                    BonusListId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeritePowers", x => x.AzeritePowerId);
                    table.ForeignKey(
                        name: "FK_AzeritePowers_AzeriteEmpoweredItems_Id",
                        column: x => x.Id,
                        principalTable: "AzeriteEmpoweredItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AzeritePowers_Id",
                table: "AzeritePowers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AzeriteItems");

            migrationBuilder.DropTable(
                name: "AzeritePowers");

            migrationBuilder.DropTable(
                name: "AzeriteEmpoweredItems");
        }
    }
}
