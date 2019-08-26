using System.Collections.Generic;

namespace WoWJunkyard.Models.User
{
    public class WoWAccount
    {
        public WoWAccount()
        {
            this.Characters = new List<Character.Character>();
        }
        
        public string Id { get; set; }

        public string Username { get; set; }

        public string Region { get; set; }

        public string Realm { get; set; }

        public ICollection<Character.Character> Characters { get; set; }

        public bool IsVerified { get; set; }
    }
}