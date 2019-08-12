using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WoWJunkyard.Views.ViewModels
{
    public class NewsViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Posted on: ")]
        public DateTime PostedOn { get; set; }

        public string Image { get; set; }
    }
}