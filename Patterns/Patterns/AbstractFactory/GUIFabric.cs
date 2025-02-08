namespace Patterns.Patterns.AbstractFactory;

public abstract class GuiFabric
{
    public abstract Button CreateButton();
    public abstract TextBlock CreateTextBlock();
}