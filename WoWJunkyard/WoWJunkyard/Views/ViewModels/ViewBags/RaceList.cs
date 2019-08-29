﻿using System.Collections.Generic;

namespace WoWJunkyard.Views.ViewModels.ViewBags
{
    public class RaceList
    {
        public RaceList()
        {
            this.RaceNames = new Dictionary<long,string>()
            {
                {1, "Human"},
                {2, "Orc"},
                {3, "Dwarf"},
                {4, "Night Elf"},
                {5, "Undead"},
                {6, "Tauren"},
                {7, "Gnome"},
                {8, "Troll"},
                {9, "Goblin"},
                {10, "Blood Elf"},
                {11, "Draenei"},
                {22, "Worgen"},
                {24, "Pandaren"},
                {25, "Pandaren"},
                {26, "Pandaren"},
                {27, "Nightborne"},
                {28, "Highmountain Tauren"},
                {29, "Void Elf"},
                {30, "Lightforged Draenei"},
                {31, "Zandalari Troll"},
                {32, "Kul Tiran"},
                {34, "Dark Iron Dwarf"},
            };
        }

        public Dictionary<long, string> RaceNames { get; set; }
    }
}