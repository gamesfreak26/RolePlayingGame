using System;

namespace RolePlayingGame {
    class Program {
        static void Main(string[] args) {
            Weapon LongSword = new Weapon("Long Sword",
                "It's a really long sword.  No really, it is...",
                2);
            Player Player = new Player(10, LongSword);
            Enemy Enemy = new Enemy(20);
            int PlayerDamage = Player.DoDamage();
            Console.WriteLine(PlayerDamage);
            Enemy.TakeDamage(PlayerDamage);
            Console.WriteLine(Enemy.CurrentHealth);
            var randomString = Console.ReadLine();
        }
    }
}
