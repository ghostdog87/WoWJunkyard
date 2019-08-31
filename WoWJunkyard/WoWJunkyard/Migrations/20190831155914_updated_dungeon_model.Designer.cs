﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WoWJunkyard.Data;

namespace WoWJunkyard.Migrations
{
    [DbContext(typeof(WoWDbContext))]
    [Migration("20190831155914_updated_dungeon_model")]
    partial class updated_dungeon_model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AchievementPoints");

                    b.Property<long>("Class");

                    b.Property<long>("Faction");

                    b.Property<long>("LastModified");

                    b.Property<long>("Level");

                    b.Property<string>("Name");

                    b.Property<long>("Race");

                    b.Property<string>("Realm");

                    b.Property<string>("Thumbnail");

                    b.Property<string>("WoWAccountId");

                    b.HasKey("Id");

                    b.HasIndex("WoWAccountId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.Dungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<long>("CompletedTimestamp");

                    b.Property<long>("DungeonId");

                    b.Property<string>("DungeonName");

                    b.Property<long>("Duration");

                    b.Property<bool>("IsCompletedWithinTime");

                    b.Property<long>("KeystoneLevel");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Dungeons");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.EquippedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bonus");

                    b.Property<int?>("CharacterId");

                    b.Property<int>("ItemId");

                    b.Property<string>("Name");

                    b.Property<int>("SlotId");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.HasIndex("SlotId");

                    b.ToTable("EquippedItems");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.InventoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("InventoryTypes");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.ItemInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ItemIdNumber");

                    b.HasKey("Id");

                    b.ToTable("ItemInfos");
                });

            modelBuilder.Entity("WoWJunkyard.Models.News.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200000);

                    b.Property<string>("Image");

                    b.Property<DateTime>("PostedOn");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("WoWJunkyard.Models.User.WoWAccount", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsVerified");

                    b.Property<string>("Realm");

                    b.Property<string>("Region");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("WoWAccounts");
                });

            modelBuilder.Entity("WoWJunkyard.Models.User.WoWUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AccountId");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("WoWUser");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.Character", b =>
                {
                    b.HasOne("WoWJunkyard.Models.User.WoWAccount")
                        .WithMany("Characters")
                        .HasForeignKey("WoWAccountId");
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.Dungeon", b =>
                {
                    b.HasOne("WoWJunkyard.Models.Character.Character", "Character")
                        .WithMany("Dungeons")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoWJunkyard.Models.Character.EquippedItem", b =>
                {
                    b.HasOne("WoWJunkyard.Models.Character.Character", "Character")
                        .WithMany("EquippedItems")
                        .HasForeignKey("CharacterId");

                    b.HasOne("WoWJunkyard.Models.Character.ItemInfo", "Item")
                        .WithOne("EquippedItem")
                        .HasForeignKey("WoWJunkyard.Models.Character.EquippedItem", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoWJunkyard.Models.Character.InventoryType", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoWJunkyard.Models.User.WoWUser", b =>
                {
                    b.HasOne("WoWJunkyard.Models.User.WoWAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });
#pragma warning restore 612, 618
        }
    }
}
