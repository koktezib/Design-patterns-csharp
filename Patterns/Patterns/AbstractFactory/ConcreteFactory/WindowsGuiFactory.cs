using Patterns.Patterns.AbstractFactory.AbstractFactory;
using Patterns.Patterns.AbstractFactory.AbstractProducts;
using Patterns.Patterns.AbstractFactory.ConcreteProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteFactory;

public class WindowsGuiFactory : GuiFabric
{
    public override Button CreateButton()
    {
        return new WinButton("Button", "Button1");
    }

    public override TextBlock CreateTextBlock()
    {
        return new WinTextBlock("TextBlock", "TextBlock1", "Roboto");
    }
}