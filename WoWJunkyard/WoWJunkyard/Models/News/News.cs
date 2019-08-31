using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Models.News
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        public string Title { get; set; }

        [Required]
        [StringLength(200000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 50)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Posted on")]
        public DateTime PostedOn { get; set; }

        public string Image { get; set; }
    }
}