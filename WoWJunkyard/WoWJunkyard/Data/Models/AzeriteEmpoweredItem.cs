using System.Collections.Generic;

namespace WoWJunkyard.Data.Models
{
    public class AzeriteEmpoweredItem
    {
        public AzeriteEmpoweredItem()
        {
            this.AzeritePowers = new List<AzeritePower>();
        }

        public long Id { get; set; }

        public List<AzeritePower> AzeritePowers { get; set; }
    }
}