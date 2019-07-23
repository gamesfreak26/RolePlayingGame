using System;
using System.Collections.Generic;
using System.Text;
using RolePlayingGame.Interfaces;

namespace RolePlayingGame
{
    public class Enemy : IActor
    {
        private int _maximumHealth;

        public Enemy(int currentHealth, int maxHealth) {
            CurrentHealth = currentHealth;
            _maximumHealth = maxHealth;
        }

        public Enemy(int maxHealth) {
            CurrentHealth = maxHealth;
            _maximumHealth = maxHealth;
        }

        public int CurrentHealth { get; set; }

        public int maxHealth {
            get { return _maximumHealth; }
            set { _maximumHealth = value; }
        }

        public void Heal(int healing) {
            if ((CurrentHealth + healing) >= maxHealth) {
                CurrentHealth = maxHealth;
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
