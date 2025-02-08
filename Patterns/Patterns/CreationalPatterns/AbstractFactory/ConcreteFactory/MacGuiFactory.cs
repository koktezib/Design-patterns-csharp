using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractFactory;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractProducts;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

namespace Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteFactory;

public class MacGuiFactory : GuiFabric
{
    public override Button CreateButton()
    {
        return new MacButton("Button", "Button1");
    }

    public override TextBlock CreateTextBlock()
    {
        return new MacTextBlock("TextBlock", "TextBlock1", "MacFont");
    }
}