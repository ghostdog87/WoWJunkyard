using Microsoft.AspNetCore.Identity;

namespace WoWJunkyard.Data.Models
{
    // Add profile data for application users by adding properties to the WoWUser class
    public class WoWUser : IdentityUser
    {

        public string AccountId { get; set; }
        public WoWAccount Account { get; set; }

    }
}
