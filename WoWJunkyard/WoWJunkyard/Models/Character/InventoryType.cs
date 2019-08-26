using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WoWJunkyard.Models.Character
{
    public class InventoryType
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }
    }
}