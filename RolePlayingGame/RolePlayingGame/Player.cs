using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame {
    public class Player : IActor {

        private Dictionary<string, int> stats = new Dictionary<string, int>()
        {
            { "Strength", 8 },
            { "Constitution", 8 },
            { "Dexterity", 8 },
            { "Intelligence", 8 },
            { "Wisdom", 8 },
            { "Charisma", 8 }
        };

        private int _damage;

        public Player(int maxHealth) {
            MaximumHealth = maxHealth;
            CurrentHealth = maxHealth;
            _damage = 1;
        }

        public Player(int currentHealth, int maxHealth) {
            MaximumHealth = maxHealth;
            CurrentHealth = currentHealth;
            _damage = 1;
        }

        public int MaximumHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public int damageDealt {
            get { return _damage; }
            set { _damage = value; }
        }

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
    }
}
