using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractFactory;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractProducts;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteFactory;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

namespace PatternsTests
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void MacGuiFactory_CreateButton_ReturnsMacButton()
        {
            // Arrange
            GuiFabric factory = new MacGuiFactory();

            // Act
            Button button = factory.CreateButton();

            // Assert: Verify that the button is a MacButton and has correct properties.
            Assert.IsInstanceOf<MacButton>(button);
            Assert.That(button.Text, Is.EqualTo("Button"));
            Assert.That(button.Name, Is.EqualTo("Button1"));

            // Capture the output from the Onclick() method.
            using (StringWriter sw = new StringWriter())
            {
                // Save the current Console.Out stream.
                TextWriter originalOut = Console.Out;
                Console.SetOut(sw);

                // Act: Call Onclick and capture output.
                button.Onclick();

                // Restore the original output stream.
                Console.SetOut(originalOut);

                // Expected output should match the text plus " Mac button clicked" and a new line.
                string expectedOutput = button.Text + " Mac button clicked" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }

        [Test]
        public void MacGuiFactory_CreateTextBlock_ReturnsMacTextBlock()
        {
            // Arrange
            GuiFabric factory = new MacGuiFactory();

            // Act
            TextBlock textBlock = factory.CreateTextBlock();

            // Assert: Verify that the text block is a MacTextBlock and its properties are set correctly.
            Assert.IsInstanceOf<MacTextBlock>(textBlock);
            Assert.That(textBlock.Text, Is.EqualTo("TextBlock"));
            Assert.That(textBlock.Name, Is.EqualTo("TextBlock1"));
            Assert.That(textBlock.FontFamily, Is.EqualTo("MacFont"));
        }

        [Test]
        public void WindowsGuiFactory_CreateButton_ReturnsWinButton()
        {
            // Arrange
            GuiFabric factory = new WindowsGuiFactory();

            // Act
            Button button = factory.CreateButton();

            // Assert: Verify that the button is a WinButton and its properties are correct.
            Assert.IsInstanceOf<WinButton>(button);
            Assert.That(button.Text, Is.EqualTo("Button"));
            Assert.That(button.Name, Is.EqualTo("Button1"));

            // Capture the output from the Onclick() method.
            using (StringWriter sw = new StringWriter())
            {
                TextWriter originalOut = Console.Out;
                Console.SetOut(sw);

                // Act: Call Onclick and capture output.
                button.Onclick();

                Console.SetOut(originalOut);
                // Expected output should match the text plus " Windows" and a new line.
                string expectedOutput = button.Text + " Windows" + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }

        [Test]
        public void WindowsGuiFactory_CreateTextBlock_ReturnsWinTextBlock()
        {
            // Arrange
            GuiFabric factory = new WindowsGuiFactory();

            // Act
            TextBlock textBlock = factory.CreateTextBlock();

            // Assert: Verify that the text block is a WinTextBlock and its properties are correct.
            Assert.IsInstanceOf<WinTextBlock>(textBlock);
            Assert.That(textBlock.Text, Is.EqualTo("TextBlock"));
            Assert.That(textBlock.Name, Is.EqualTo("TextBlock1"));
            Assert.That(textBlock.FontFamily, Is.EqualTo("Roboto"));
        }
    }
}
