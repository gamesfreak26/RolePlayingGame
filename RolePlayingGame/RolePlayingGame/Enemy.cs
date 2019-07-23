using System;
using System.Collections.Generic;
using System.Text;
using RolePlayingGame.Interfaces;

namespace RolePlayingGame
{
    public class Enemy : IActor
    {
        private int _currentHealth;
        private int _maximumHealth;

        public Enemy(int currentHealth, int maxHealth) {
            _currentHealth = currentHealth;
            _maximumHealth = maxHealth;
        }

        public Enemy(int maxHealth) {
            _currentHealth = maxHealth;
            _maximumHealth = maxHealth;
        }

        public int currentHealth {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public int maxHealth {
            get { return _maximumHealth; }
            set { _maximumHealth = value; }
        }

        public void Heal(int healing) {
            if ((currentHealth + healing) >= maxHealth) {
                currentHealth = maxHealth;
            }
            else {
                currentHealth += healing;
            }
        }

        public void TakeDamage(int damage) {
            if ((currentHealth - damage) <= 0) {
                currentHealth = 0;
            }
            else {
                currentHealth -= damage;
            }
        }
    }
}
