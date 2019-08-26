using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Models.Character
{
    public class ItemInfo
    {
        
        [Key]
        public int Id { get; set; }

        public long ItemIdNumber { get; set; }

        public int EquippedItemId { get; set; }

        public EquippedItem EquippedItem { get; set; }
    }
}