using System;
using System.Collections.Generic;
using System.Text;
using RolePlayingGame.Interfaces;

namespace RolePlayingGame
{
    class Weapon : IItem
    {
        public Weapon(string name, string description, int proficiencyBonus) {
            Description = description;
            ProficiencyBonus = proficiencyBonus;
            ItemName = name;
        }
        
        List<string> types = new List<string> {
            "None",
            "Sword",
            "Axe"
        };

        public string ItemName { get; private set; }
        public string Description { get; private set; }
        public int ProficiencyBonus { get; private set; }
    }
}
