using Patterns.Patterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteProducts;

public class WinButton(string text, string name) : Button(text, name)
{
    public override void Onclick()
    {
        Console.WriteLine(Text + " Windows");
    }
}