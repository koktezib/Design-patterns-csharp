using Patterns.Patterns.AbstractFactory.AbstractFactory;
using Patterns.Patterns.AbstractFactory.AbstractProducts;
using Patterns.Patterns.AbstractFactory.ConcreteProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteFactory;

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