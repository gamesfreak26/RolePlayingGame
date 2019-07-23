using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame.Interfaces {
    interface IActor {
        void TakeDamage(int damage);
        void Heal(int healing);
    }
}
