using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace WoWJunkyard.Data.Models
{
    public class ItemInfo
    {
        public ItemInfo()
        {
            this.Stats = new List<Stat>();
        }

        [Key]
        public long ItemInfoId { get; set; }

        public long Id { get; set; }

        public int ItemsId { get; set; }
        public Items Items { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public long Quality { get; set; }

        public long ItemLevel { get; set; }

        public List<Stat> Stats { get; set; }

        public long Armor { get; set; }

        public string Context { get; set; }

        public string BonusLists { get; set; }

        public long ArtifactId { get; set; }

        public long DisplayInfoId { get; set; }

        public long ArtifactAppearanceId { get; set; }

        [NotMapped]
        public List<object> ArtifactTraits { get; set; }

        [NotMapped]
        public List<object> Relics { get; set; }

        public long AzeriteItemId { get; set; }

        public AzeriteItem AzeriteItem { get; set; }

        public long AzeriteEmpoweredItemId { get; set; }

        public AzeriteEmpoweredItem AzeriteEmpoweredItem { get; set; }

    }

}