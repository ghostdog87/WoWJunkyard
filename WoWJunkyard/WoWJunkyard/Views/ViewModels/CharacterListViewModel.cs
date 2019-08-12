using WoWJunkyard.Views.Models.Enums;

namespace WoWJunkyard.Views.Models
{
    public class CharacterListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Realm { get; set; }

        public long Class { get; set; }

        public long Race { get; set; }

        public long Level { get; set; }

        public long AchievementPoints { get; set; }

        public string Thumbnail { get; set; }

        public long Faction { get; set; }
    }
}