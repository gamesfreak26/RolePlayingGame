using System;

namespace RolePlayingGame {
    class Program {
        static void Main(string[] args) {
            Player Player = new Player(10);
            Enemy Enemy = new Enemy(5);
            Console.WriteLine(Enemy.currentHealth);
            var randomString = Console.ReadLine();
        }
    }
}
