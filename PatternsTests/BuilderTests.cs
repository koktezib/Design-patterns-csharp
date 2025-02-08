using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.AbstractBuilder;
using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.ConcreteBuilder;
using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.Director;
using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.Product;

namespace PatternsTests
{
    [TestFixture]
    public class BuilderTests
    {
        private IEnemyBuilder _builder;
        private EnemyDirector _director;

        [SetUp]
        public void Setup()
        {
            // Create a new builder and director before each test
            _builder = new EnemyBuilder();
            _director = new EnemyDirector(_builder);
        }

        [Test]
        public void BuildSwordsman_ShouldReturnCorrectEnemy()
        {
            // Act: Build a swordsman enemy using the director.
            Enemy swordsman = _director.BuildSwordsman();

            // Assert: Verify that the enemy has the correct properties.
            Assert.That(swordsman.Name, Is.EqualTo("Swordsman"));
            Assert.That(swordsman.Health, Is.EqualTo(10));
            Assert.That(swordsman.Damage, Is.EqualTo(5));
            Assert.That(swordsman.Weapon, Is.EqualTo(WeaponType.Sword));
        }

        [Test]
        public void BuildArcher_ShouldReturnCorrectEnemy()
        {
            // Act: Build an archer enemy using the director.
            Enemy archer = _director.BuildArcher();

            // Assert: Verify that the enemy has the correct properties.
            Assert.That(archer.Name, Is.EqualTo("Archer"));
            Assert.That(archer.Health, Is.EqualTo(10));
            Assert.That(archer.Damage, Is.EqualTo(5));
            Assert.That(archer.Weapon, Is.EqualTo(WeaponType.Bow));
        }

        [Test]
        public void Builder_ShouldResetAfterBuild()
        {
            // Arrange: Set custom values using the builder.
            _builder.SetName("CustomEnemy");
            _builder.SetHealth(20);
            _builder.SetDamage(10);
            _builder.SetWeaponType(WeaponType.Bow);

            // Act: Build the first enemy.
            Enemy customEnemy = _builder.Build();

            // Now build another enemy without setting any values,
            // expecting the default values.
            Enemy defaultEnemy = _builder.Build();

            // Assert: The second enemy should have default values.
            // Name should default to "Default enemy name"
            Assert.That(defaultEnemy.Name, Is.EqualTo("Default enemy name"));
            // Health and Damage should be 0
            Assert.That(defaultEnemy.Health, Is.EqualTo(0));
            Assert.That(defaultEnemy.Damage, Is.EqualTo(0));
            // Weapon should be set to default(WeaponType). Typically this is 0,
            // which corresponds to the first defined enum value (e.g., WeaponType.Sword).
            Assert.That(defaultEnemy.Weapon, Is.EqualTo(default(WeaponType)));
        }
    }
}
