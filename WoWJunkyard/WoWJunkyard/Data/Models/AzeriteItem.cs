using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Data.Models
{
    public class AzeriteItem
    {
        [Key]
        public int AzeriteItemId { get; set; }

        public long Id { get; set; }

        public long AzeriteLevel { get; set; }

        public long AzeriteExperience { get; set; }

        public long AzeriteExperienceRemaining { get; set; }
    }
}