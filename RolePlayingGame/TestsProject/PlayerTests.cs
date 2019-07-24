using NUnit.Framework;
using RolePlayingGame;

namespace Tests {
    public class PlayerTests {
        Player player;
        Weapon LongSword;

        [SetUp]
        public void Setup() {
            LongSword = new Weapon("Long Sword",
                "It's a really long sword.  No really, it is...",
                2);
            player = new Player(9, 10, LongSword);
        }

        [Test]
        public void PlayerTakesDamage() {
            player.TakeDamage(1);
            Assert.AreEqual(8, player.CurrentHealth);
        }

        [Test]
        public void PlayerTakesFatalDamage() {
            player.TakeDamage(20);
            Assert.AreEqual(0, player.CurrentHealth);
        }
               
        [Test]
        public void PlayerHealsDamage() {
            player.Heal(1);
            Assert.AreEqual(10, player.CurrentHealth);
        }

        [Test]
        public void PlayerHealsOverMaxHealth() {
            player.Heal(3);
            Assert.AreEqual(10, player.CurrentHealth);
        }

        [Test]
        public void PlayerDamageNoWeapon()
        {
            var axe = new Weapon("axe", 
                "axeDescription",
                3);
            var player2 = new Player(10, null);
            Assert.AreEqual(8, player2.DoDamage());
        }


        [Test]
        public void PlayerDamageWeapon()
        {
            int damage = player.DoDamage();
            Assert.AreEqual(10, damage);
        }

        [Test]
        public void ChangePlayerStrength()
        {
            player.ChangeStat("Strength", 9);
            Assert.AreEqual(9, player.stats["Strength"]);
        }
    }
}