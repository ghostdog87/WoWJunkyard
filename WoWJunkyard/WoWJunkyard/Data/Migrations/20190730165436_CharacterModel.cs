using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoWJunkyard.Data.Migrations
{
    public partial class CharacterModel : Migration
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
                    AzeriteItemId = table.Column<long>(nullable: false)
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
                name: "Damages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Min = table.Column<long>(nullable: false),
                    Max = table.Column<long>(nullable: false),
                    ExactMin = table.Column<long>(nullable: false),
                    ExactMax = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageItemLevel = table.Column<long>(nullable: false),
                    AverageItemLevelEquipped = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WoWAccounts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Realm = table.Column<string>(nullable: true),
                    IsVerified = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoWAccounts", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "WeaponInfos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DamageId = table.Column<long>(nullable: false),
                    WeaponSpeed = table.Column<double>(nullable: false),
                    Dps = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponInfos_Damages_DamageId",
                        column: x => x.DamageId,
                        principalTable: "Damages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemInfos",
                columns: table => new
                {
                    ItemInfoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<long>(nullable: false),
                    ItemsId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Quality = table.Column<long>(nullable: false),
                    ItemLevel = table.Column<long>(nullable: false),
                    Armor = table.Column<long>(nullable: false),
                    Context = table.Column<string>(nullable: true),
                    BonusLists = table.Column<string>(nullable: true),
                    ArtifactId = table.Column<long>(nullable: false),
                    DisplayInfoId = table.Column<long>(nullable: false),
                    ArtifactAppearanceId = table.Column<long>(nullable: false),
                    AzeriteItemId = table.Column<long>(nullable: false),
                    AzeriteEmpoweredItemId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInfos", x => x.ItemInfoId);
                    table.ForeignKey(
                        name: "FK_ItemInfos_AzeriteEmpoweredItems_AzeriteEmpoweredItemId",
                        column: x => x.AzeriteEmpoweredItemId,
                        principalTable: "AzeriteEmpoweredItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemInfos_AzeriteItems_AzeriteItemId",
                        column: x => x.AzeriteItemId,
                        principalTable: "AzeriteItems",
                        principalColumn: "AzeriteItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemInfos_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Realm = table.Column<string>(nullable: true),
                    Class = table.Column<long>(nullable: false),
                    Race = table.Column<long>(nullable: false),
                    Level = table.Column<long>(nullable: false),
                    AchievementPoints = table.Column<long>(nullable: false),
                    Faction = table.Column<long>(nullable: false),
                    ItemsId = table.Column<int>(nullable: false),
                    WoWAccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_WoWAccounts_WoWAccountId",
                        column: x => x.WoWAccountId,
                        principalTable: "WoWAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WoWUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoWUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WoWUser_WoWAccounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "WoWAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatStat = table.Column<long>(nullable: false),
                    Amount = table.Column<long>(nullable: false),
                    ItemInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_ItemInfos_ItemInfoId",
                        column: x => x.ItemInfoId,
                        principalTable: "ItemInfos",
                        principalColumn: "ItemInfoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AccomplishedLevel = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dungeons_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AzeritePowers_Id",
                table: "AzeritePowers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ItemsId",
                table: "Characters",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WoWAccountId",
                table: "Characters",
                column: "WoWAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Dungeons_CharacterId",
                table: "Dungeons",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInfos_AzeriteEmpoweredItemId",
                table: "ItemInfos",
                column: "AzeriteEmpoweredItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInfos_AzeriteItemId",
                table: "ItemInfos",
                column: "AzeriteItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemInfos_ItemsId",
                table: "ItemInfos",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_ItemInfoId",
                table: "Stats",
                column: "ItemInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponInfos_DamageId",
                table: "WeaponInfos",
                column: "DamageId");

            migrationBuilder.CreateIndex(
                name: "IX_WoWUser_AccountId",
                table: "WoWUser",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AzeritePowers");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WeaponInfos");

            migrationBuilder.DropTable(
                name: "WoWUser");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "ItemInfos");

            migrationBuilder.DropTable(
                name: "Damages");

            migrationBuilder.DropTable(
                name: "WoWAccounts");

            migrationBuilder.DropTable(
                name: "AzeriteEmpoweredItems");

            migrationBuilder.DropTable(
                name: "AzeriteItems");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
