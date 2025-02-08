using Patterns.Patterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.AbstractFactory.AbstractFactory;

public abstract class GuiFabric
{
    public abstract Button CreateButton();
    public abstract TextBlock CreateTextBlock();
}