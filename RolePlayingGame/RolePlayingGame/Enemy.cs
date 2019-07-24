using System;
using System.Collections.Generic;
using System.Text;
using RolePlayingGame.Interfaces;

namespace RolePlayingGame
{
    public class Enemy : IActor
    {
        public Enemy(int currentHealth, int maxHealth) {
            CurrentHealth = currentHealth;
            MaximumHealth = maxHealth;
        }

        public Enemy(int maxHealth) {
            CurrentHealth = maxHealth;
            MaximumHealth = maxHealth;
        }

        private Dictionary<string, int> stats = new Dictionary<string, int>()
        {
            { "Strength", 8 },
            { "Constitution", 8 },
            { "Dexterity", 8 },
            { "Intelligence", 8 },
            { "Wisdom", 8 },
            { "Charisma", 8 }
        };

        public int CurrentHealth { get; set; }
         
        public int MaximumHealth { get; set; }
        

        public void Heal(int healing) {
            if ((CurrentHealth + healing) >= MaximumHealth) {
                CurrentHealth = MaximumHealth;
            }
            else {
                CurrentHealth += healing;
            }
        }

        public void TakeDamage(int damage) {
            if ((CurrentHealth - damage) <= 0) {
                CurrentHealth = 0;
            }
            else {
                CurrentHealth -= damage;
            }
        }
    }
}
