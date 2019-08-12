using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Data.Models
{
    public class AzeriteEmpoweredItem
    {
        public AzeriteEmpoweredItem()
        {
            this.AzeritePowers = new List<AzeritePower>();
        }

        [Key]
        public long Id { get; set; }

        public List<AzeritePower> AzeritePowers { get; set; }
    }
}