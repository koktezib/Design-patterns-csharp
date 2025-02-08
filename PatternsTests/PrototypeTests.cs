using Patterns.Patterns.CreationalPatterns.Prototype.ConcretePrototype;
using Patterns.Patterns.CreationalPatterns.Prototype.Prototype;

namespace PatternsTests
{
    [TestFixture]
    public class PrototypeTests
    {
        [Test]
        public void ArcherClone_ShouldReturnCloneWithSameProperties_AndBeIndependent()
        {
            // Arrange
            Archer originalArcher = new Archer(10, "Robin", 15);

            // Act: Clone the original archer.
            IUnit clonedUnit = originalArcher.Clone();
            
            // Assert: Verify that the cloned instance is not the same reference as the original.
            Assert.That(clonedUnit, Is.Not.SameAs(originalArcher));
            
            // Cast the clone to Archer to access its properties.
            Archer clonedArcher = clonedUnit as Archer;
            Assert.IsNotNull(clonedArcher, "Cloned unit should be of type Archer");
            
            // Assert that the properties are identical.
            Assert.That(clonedArcher.Damage, Is.EqualTo(originalArcher.Damage));
            Assert.That(clonedArcher.Name, Is.EqualTo(originalArcher.Name));
            Assert.That(clonedArcher.Range, Is.EqualTo(originalArcher.Range));
            
            // Act: Change the name on the clone.
            clonedArcher.ChangeName("Hood");
            
            // Assert: The original's name remains unchanged.
            Assert.That(clonedArcher.Name, Is.Not.EqualTo(originalArcher.Name));
        }

        [Test]
        public void ArcherAttack_ShouldOutputCorrectMessage()
        {
            // Arrange
            Archer archer = new Archer(10, "Robin", 15);
            
            // Capture the console output.
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOut = Console.Out;
                Console.SetOut(sw);
                
                // Act: Call the Attack method.
                archer.Attack();
                
                // Restore the original output.
                Console.SetOut(originalOut);
                
                // Expected output: "Robinattacked" + newline.
                string expectedOutput = "Robinattacked" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }

        [Test]
        public void SwordsmanClone_ShouldReturnCloneWithSameProperties_AndBeIndependent()
        {
            // Arrange
            Swordsman originalSwordsman = new Swordsman(20, "Arthur");

            // Act: Clone the original swordsman.
            IUnit clonedUnit = originalSwordsman.Clone();
            
            // Assert: Verify that the cloned instance is not the same reference as the original.
            Assert.That(clonedUnit, Is.Not.SameAs(originalSwordsman));
            
            // Cast the clone to Swordsman.
            Swordsman clonedSwordsman = clonedUnit as Swordsman;
            Assert.IsNotNull(clonedSwordsman, "Cloned unit should be of type Swordsman");
            
            // Assert that the properties are identical.
            Assert.That(clonedSwordsman.Damage, Is.EqualTo(originalSwordsman.Damage));
            Assert.That(clonedSwordsman.Name, Is.EqualTo(originalSwordsman.Name));
            
            // Act: Change the name on the clone.
            clonedSwordsman.ChangeName("Lancelot");
            
            // Assert: The original's name remains unchanged.
            Assert.That(clonedSwordsman.Name, Is.Not.EqualTo(originalSwordsman.Name));
        }

        [Test]
        public void SwordsmanAttack_ShouldOutputCorrectMessage()
        {
            // Arrange
            Swordsman swordsman = new Swordsman(20, "Arthur");
            
            // Capture the console output.
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOut = Console.Out;
                Console.SetOut(sw);
                
                // Act: Call the Attack method.
                swordsman.Attack();
                
                // Restore the original output.
                Console.SetOut(originalOut);
                
                // Expected output: "Arthurattacked" + newline.
                string expectedOutput = "Arthurattacked" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }
    }
}
