using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame {
    class Player : Interfaces.IActor {

        private int _currentHealth;
        private int _maximumHealth;
        private int _damageDealt;
        
        public Player(int maxHealth) {
            _maximumHealth = maxHealth;
            _currentHealth = maxHealth;
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
