using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame {
    public class Player : IActor {

        public int MaximumHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public Weapon WeaponItem { get; private set; }

        public Player(int maxHealth, Weapon weapon) {
            MaximumHealth = maxHealth;
            CurrentHealth = maxHealth;
        }
        
        public Player(int currentHealth, int maxHealth, Weapon weapon) {
            _maximumHealth = maxHealth;
            _currentHealth = currentHealth;
            WeaponItem = weapon;
        }

        public Player(int currentHealth, int maxHealth) {
            MaximumHealth = maxHealth;
            CurrentHealth = currentHealth;
            _damage = 1;
        }

        public Dictionary<string, int> stats = new Dictionary<string, int>()
        {
            { "Strength", 8 },
            { "Constitution", 8 },
            { "Dexterity", 8 },
            { "Intelligence", 8 },
            { "Wisdom", 8 },
            { "Charisma", 8 }
        };

        public void TakeDamage(int damage) {
            if ((CurrentHealth - damage) <= 0) {
                CurrentHealth = 0;
            }
            else {
                CurrentHealth -= damage;
            }
        }

        public void Heal(int healing) {
            if ((CurrentHealth + healing) >= MaximumHealth) {
                CurrentHealth = MaximumHealth;
            } 
            else {
                CurrentHealth += healing;
            }
        }

        public void ChangeStat(string statName, int statNumber) {
            if (stats.ContainsKey(statName)) { 
                stats[statName] = statNumber;
            }
        }

        public int DoDamage() {
            if (WeaponItem != null) {
                return stats["Strength"] + WeaponItem.ProficiencyBonus;
            }
            return stats["Strength"];
        }
    }
}
