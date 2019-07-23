using NUnit.Framework;
using RolePlayingGame;

namespace TestsProject
{
    class EnemyTests
    {
        Enemy Enemy;

        [SetUp]
        public void Setup() {
            Enemy = new Enemy(9, 10);
        }

        [Test]
        public void EnemyTakesDamage() {
            Enemy.TakeDamage(1);
            Assert.AreEqual(8, Enemy.currentHealth);
        }

        [Test]
        public void EnemyTakesFatalDamage() {
            Enemy.TakeDamage(20);
            Assert.AreEqual(0, Enemy.currentHealth);
        }

        [Test]
        public void EnemyHealsDamage() {
            Enemy.Heal(1);
            Assert.AreEqual(10, Enemy.currentHealth);
        }

        [Test]
        public void EnemyHealsOverMaxHealth() {
            Enemy.Heal(20);
            Assert.AreEqual(10, Enemy.currentHealth);
        }
    }
}
