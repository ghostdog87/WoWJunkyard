using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data.Models;
using WoWJunkyard.Models.Character;
using WoWJunkyard.Models.News;
using WoWJunkyard.Models.User;

namespace WoWJunkyard.Data
{
    public class WoWDbContext : IdentityDbContext<WoWUser, IdentityRole, string>
    {
        public WoWDbContext(DbContextOptions<WoWDbContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<ItemInfo> ItemInfos { get; set; }
        public DbSet<EquippedItem> EquippedItems { get; set; }
        public DbSet<InventoryType> InventoryTypes { get; set; }
        public DbSet<WoWAccount> WoWAccounts { get; set; }
        public DbSet<WoWUser> WoWUsers { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<string>>()
                .HasKey(i => new { i.UserId, i.RoleId });

            builder.Entity<IdentityUserToken<string>>()
                .HasKey(x => x.UserId);

            builder.Entity<EquippedItem>()
                .HasOne(x => x.Item)
                .WithOne(x => x.EquippedItem)
                .HasForeignKey<EquippedItem>(x=>x.ItemId);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
