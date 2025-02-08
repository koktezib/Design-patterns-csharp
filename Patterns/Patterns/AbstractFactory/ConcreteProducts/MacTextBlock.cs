using Patterns.Patterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteProducts;

public class MacTextBlock(string text, string name, string fontFamily) : TextBlock(text, name, fontFamily)
{
    
}