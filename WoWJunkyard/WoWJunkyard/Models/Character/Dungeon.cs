using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Models.Character
{
    public class Dungeon
    {
        [Key]
        public int Id { get; set; }

        public long CompletedTimestamp { get; set; }

        public long Duration { get; set; }

        public long KeystoneLevel { get; set; }

        public string DungeonName { get; set; }

        public long DungeonId { get; set; }

        public bool IsCompletedWithinTime { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }
    }
}