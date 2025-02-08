using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractFactory;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractProducts;
using Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

namespace Patterns.Patterns.CreationalPatterns.AbstractFactory.ConcreteFactory;

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