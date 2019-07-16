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

        public DbSet<WoWAccount> WoWAccounts { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Dungeon> Dungeons { get; set; }
    }
}
