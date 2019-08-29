using System.Collections.Generic;

namespace WoWJunkyard.Views.ViewModels.ViewBags
{
    public class FactionList
    {
        public FactionList()
        {
            this.FactionNames = new Dictionary<long, string>()
            {
                {0, "Neutral"},
                {1, "Horde"},
                {2, "Alliance"}
            };
        }

        public Dictionary<long, string> FactionNames { get; set; }
    }
}