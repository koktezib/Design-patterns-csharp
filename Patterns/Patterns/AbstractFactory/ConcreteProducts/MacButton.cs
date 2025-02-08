using Patterns.Patterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteProducts;

public class MacButton(string text, string name) : Button(text, name)
{
    public override void Onclick()
    {
        Console.WriteLine(Text + " Mac button clicked");
    }
}