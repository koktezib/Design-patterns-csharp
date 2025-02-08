using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

public class MacButton(string text, string name) : Button(text, name)
{
    public override void Onclick()
    {
        Console.WriteLine(Text + " Mac button clicked");
    }
}