using Patterns.Patterns.AbstractFactory.AbstractProducts;

namespace Patterns.Patterns.AbstractFactory.ConcreteProducts;

public class WinTextBlock(string text, string name, string fontFamily) : TextBlock(text, name, fontFamily)
{
    
}