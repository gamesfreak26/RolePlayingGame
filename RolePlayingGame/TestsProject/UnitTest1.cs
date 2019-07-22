using NUnit.Framework;
using RolePlayingGame;

namespace Tests {
    public class Tests {


        [SetUp]
        public void Setup() {
        }

        [Test]
        public void PlayerTakesDamage() {
            var player = new Player(10);
            player.TakeDamage(1);
            Assert.AreEqual(9, player.currentHealth);
        }

        [Test]
        public void PlayerHealsDamage() {
            var player2 = new Player(9, 10);
            player2.Heal(1);
            Assert.AreEqual(10, player2.currentHealth);
        }
    }
}