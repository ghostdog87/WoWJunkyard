using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Models.Character
{
    public class EquippedItem
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }

        public ItemInfo Item { get; set; }

        public int SlotId { get; set; }

        public InventoryType Slot { get; set; }

        public string Bonus { get; set; }

        public string Name { get; set; }

        public Character Character { get; set; }

    }
}