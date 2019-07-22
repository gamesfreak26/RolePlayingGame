using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame.Interfaces {
    interface IActor {
        int maxHealth { get; set; }

        void TakeDamage(int damage);
        void Heal(int healing);
    }
}
