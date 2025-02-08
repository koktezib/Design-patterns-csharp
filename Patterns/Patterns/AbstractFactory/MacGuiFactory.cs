namespace Patterns.Patterns.AbstractFactory;

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