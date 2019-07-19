using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WoWJunkyard.Data.Models
{
    public class Character
    {
        public Character()
        {
            this.Items = new List<Item>();
            this.Dungeons = new List<Dungeon>();
        }
        public int Id { get; set; }

        public int Level { get; set; }

        public ICollection<Item> Items { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public ICollection<Dungeon> Dungeons { get; set; }
    }
}