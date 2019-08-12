namespace WoWJunkyard.Data.Models
{
    public class WeaponInfo
    {
        public long Id { get; set; }

        public long DamageId { get; set; }

        public Damage Damage { get; set; }

        public double WeaponSpeed { get; set; }

        public double Dps { get; set; }
    }
}