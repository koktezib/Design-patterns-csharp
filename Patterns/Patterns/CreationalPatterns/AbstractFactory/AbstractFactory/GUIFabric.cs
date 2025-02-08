using Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.CreationalPatterns.AbstractFactory.AbstractFactory;

public abstract class GuiFabric
{
    public abstract Button CreateButton();
    public abstract TextBlock CreateTextBlock();
}