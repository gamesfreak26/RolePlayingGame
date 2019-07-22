using NUnit.Framework;
using RolePlayingGame;

namespace Tests {
    public class PlayerFullHealthTests {
        Player player;

        [SetUp]
        public void Setup() {
            player = new Player(9, 10);
        }

        [Test]
        public void PlayerTakesDamage() {
            player.TakeDamage(1);
            Assert.AreEqual(8, player.currentHealth);
        }

        [Test]
        public void PlayerTakesFatalDamage() {
            player.TakeDamage(20);
            Assert.AreEqual(0, player.currentHealth);
        }
               
        [Test]
        public void PlayerHealsDamage() {
            player.Heal(1);
            Assert.AreEqual(10, player.currentHealth);
        }

        [Test]
        public void PlayerHealsOverMaxHealth() {
            player.Heal(3);
            Assert.AreEqual(10, player.currentHealth);
        }

    }
}