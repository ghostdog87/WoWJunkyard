using System.Collections.Generic;

namespace WoWJunkyard.Data.Models
{
    public class WoWAccount
    {
        public WoWAccount()
        {
            this.Characters = new List<Character>();
        }
        
        public string Id { get; set; }

        public string Username { get; set; }

        public string Region { get; set; }

        public string Realm { get; set; }

        public ICollection<Character> Characters { get; set; }

        public bool IsVerified { get; set; }
    }
}