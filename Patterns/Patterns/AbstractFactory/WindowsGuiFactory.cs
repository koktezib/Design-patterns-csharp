namespace Patterns.Patterns.AbstractFactory;

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