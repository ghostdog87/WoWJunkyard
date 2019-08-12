using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Data.Models
{
    public class AzeritePower
    {
        [Key]
        public int AzeritePowerId { get; set; }

        public long Id { get; set; }

        public long Tier { get; set; }

        public long SpellId { get; set; }

        public long BonusListId { get; set; }
    }
}