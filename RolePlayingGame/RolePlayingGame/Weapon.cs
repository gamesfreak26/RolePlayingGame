using System;
using System.Collections.Generic;
using System.Text;
using RolePlayingGame.Interfaces;

namespace RolePlayingGame
{
    class Weapon : IItem
    {
        public Weapon(string description, int proficiencyBonus) {
            Description = description;
            ProficiencyBonus = proficiencyBonus;
        }
        
        List<string> types = new List<string> {
            "None",
            "Sword",
            "Axe"
        };

        public string Description { get; private set; }
        public int ProficiencyBonus { get; private set; }
    }
}
