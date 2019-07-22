using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame {
    public class Player : IActor {

        private int _currentHealth;
        private int _maximumHealth;
        private int _damageDealt;
        
        public Player(int maxHealth) {
            _maximumHealth = maxHealth;
            _currentHealth = maxHealth;
        }

        public Player(int currentHealth, int maxHealth) {
            _maximumHealth = maxHealth;
            _currentHealth = currentHealth;
        }

        public int maxHealth {
            get { return _maximumHealth; }
            set { _maximumHealth = value; }
        }

        public int currentHealth {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public int damageDealtToEnemy {
            get { return _damageDealt; }
            set { _damageDealt = value; }
        }

        public void TakeDamage(int damage) {
            currentHealth -= damage;
        }

        public void Heal(int healing) {
            currentHealth += healing;
        }

        public void DoDamage() {

        }
    }
}
