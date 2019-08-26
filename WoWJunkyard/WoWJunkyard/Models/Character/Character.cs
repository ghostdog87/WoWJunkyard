using System.Collections.Generic;
using WoWJunkyard.Data.Models;

namespace WoWJunkyard.Models.Character
{
    public class Character
    {
        public Character()
        {
            this.Dungeons = new List<Dungeon>();
            this.EquippedItems = new List<EquippedItem>();
        }

        public int Id { get; set; }

        public long LastModified { get; set; }

        public string Name { get; set; }

        public string Realm { get; set; }

        public long Class { get; set; }

        public long Race { get; set; }

        public long Level { get; set; }

        public long AchievementPoints { get; set; }

        public string Thumbnail { get; set; }

        public long Faction { get; set; }

        public List<Dungeon> Dungeons { get; set; }

        public List<EquippedItem> EquippedItems { get; set; }
    }
}