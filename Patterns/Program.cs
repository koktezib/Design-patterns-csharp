using Patterns.Patterns.AbstractFactory;
using Patterns.Patterns.Factory_Method;
using Patterns.Patterns.Prototype;

namespace Patterns;

public static class Program
{
    public static void Main()
    {
        GuiFabric guiFabric = new MacGuiFactory();
        
        Button button = guiFabric.CreateButton();
        TextBlock textBlock = guiFabric.CreateTextBlock();
    }
}