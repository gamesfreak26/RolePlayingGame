﻿using RolePlayingGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame {
    public class Player : IActor {

        private int _currentHealth;
        private int _maximumHealth;
        private int _damage;
        Enemy Enemy = new Enemy(10);
        
        public Player(int maxHealth) {
            _maximumHealth = maxHealth;
            _currentHealth = maxHealth;
            _damage = 1;
        }

        public Player(int currentHealth, int maxHealth) {
            _maximumHealth = maxHealth;
            _currentHealth = currentHealth;
            _damage = 1;
        }

        public int maxHealth {
            get { return _maximumHealth; }
            set { _maximumHealth = value; }
        }

        public int currentHealth {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public int damageDealt {
            get { return _damage; }
            set { _damage = value; }
        }

        public void TakeDamage(int damage) {
            if ((currentHealth - damage) <= 0) {
                currentHealth = 0;
            }
            else {
                currentHealth -= damage;
            }
        }

        public void Heal(int healing) {
            if ((currentHealth + healing) >= maxHealth) {
                currentHealth = 10;
            } 
            else {
                currentHealth += healing;
            }
        }
    }
}
