using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoWJunkyard.Data.Models;

namespace WoWJunkyard.Data
{
    public class WoWDbContext : IdentityDbContext<WoWUser, IdentityRole, string>
    {
        public WoWDbContext(DbContextOptions<WoWDbContext> options)
            : base(options)
        {
        }

        public DbSet<AzeriteEmpoweredItem> AzeriteEmpoweredItems { get; set; }
        public DbSet<AzeriteItem> AzeriteItems { get; set; }
        public DbSet<AzeritePower> AzeritePowers { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Damage> Damages { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<ItemInfo> ItemInfos { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<WeaponInfo> WeaponInfos { get; set; }
        public DbSet<WoWAccount> WoWAccounts { get; set; }
        public DbSet<WoWUser> WoWUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Items>()
                .HasMany(x => x.ItemInfos)
                .WithOne(x => x.Items)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<string>>()
                .HasKey(x => x.RoleId);

            builder.Entity<IdentityUserToken<string>>()
                .HasKey(x => x.UserId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
