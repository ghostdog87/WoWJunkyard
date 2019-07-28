namespace WoWJunkyard.Data.Models
{
    public class Items
    {
        public int Id { get; set; }

        public long AverageItemLevel { get; set; }

        public long AverageItemLevelEquipped { get; set; }

        public long HeadId { get; set; }

        public ItemInfo Head { get; set; }

        public long NeckId { get; set; }

        public ItemInfo Neck { get; set; }

        public long ShoulderId { get; set; }

        public ItemInfo Shoulder { get; set; }

        public long BackId { get; set; }

        public ItemInfo Back { get; set; }

        public long ChestId { get; set; }

        public ItemInfo Chest { get; set; }

        public long WristId { get; set; }

        public ItemInfo Wrist { get; set; }

        public long HandsId { get; set; }

        public ItemInfo Hands { get; set; }

        public long WaistId { get; set; }

        public ItemInfo Waist { get; set; }

        public long LegsId { get; set; }

        public ItemInfo Legs { get; set; }

        public long FeetId { get; set; }

        public ItemInfo Feet { get; set; }

        public long Finger1Id { get; set; }

        public ItemInfo Finger1 { get; set; }

        public long Finger2Id { get; set; }

        public ItemInfo Finger2 { get; set; }

        public long Trinket1Id { get; set; }

        public ItemInfo Trinket1 { get; set; }

        public long Trinket2Id { get; set; }

        public ItemInfo Trinket2 { get; set; }

        public long MainHandId { get; set; }

        public WeaponInfo MainHand { get; set; }

        public long OffHandId { get; set; }

        public ItemInfo OffHand { get; set; }
    }
}