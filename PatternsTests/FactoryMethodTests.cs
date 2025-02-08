using Patterns.Patterns.CreationalPatterns.Factory_Method.AbstractProduct;
using Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteCreators;
using Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteProducts;
using Patterns.Patterns.CreationalPatterns.Factory_Method.Creator;

namespace PatternsTests
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void FireMageCreator_Create_ReturnsFireMageAndCastsFireSpell()
        {
            // Arrange
            MageCreator fireMageCreator = new FireMageCreator("Fire Mage");
            
            // Act
            Mage mage = fireMageCreator.Create();
            
            // Assert that the created mage is of type FireMage.
            Assert.IsInstanceOf<FireMage>(mage);

            // Capture the console output from the CastSpell method.
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOutput = Console.Out;
                Console.SetOut(sw);

                mage.CastSpell();

                Console.SetOut(originalOutput);

                // Expected output should match "Fire spell" followed by a newline.
                string expectedOutput = "Fire spell" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }

        [Test]
        public void FrostMageCreator_Create_ReturnsFrostMageAndCastsFrostSpell()
        {
            // Arrange
            MageCreator frostMageCreator = new FrostMageCreator("Frost Mage");
            
            // Act
            Mage mage = frostMageCreator.Create();
            
            // Assert that the created mage is of type FrostMage.
            Assert.IsInstanceOf<FrostMage>(mage);

            // Capture the console output from the CastSpell method.
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOutput = Console.Out;
                Console.SetOut(sw);

                mage.CastSpell();

                Console.SetOut(originalOutput);

                // Expected output should match "Frost spell" followed by a newline.
                string expectedOutput = "Frost spell" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }
    }
}
