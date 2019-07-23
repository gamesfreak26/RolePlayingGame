using System;

namespace RolePlayingGame {
    class Program {
        static void Main(string[] args) {
            Player Player = new Player(10);
            Weapon LongSword = new Weapon("Long Sword",
                "It's a really long sword.  No really, it is...",
                2);
            Enemy Enemy = new Enemy(5);
            Console.WriteLine(Enemy.CurrentHealth);
            var randomString = Console.ReadLine();
        }
    }
}
