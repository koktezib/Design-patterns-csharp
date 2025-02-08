namespace Patterns.Patterns.AbstractFactory.AbstractProducts;

public abstract class Button (string text, string name)
{
    public string Text { get; set; } = text;
    public string Name { get; set; } = name;

    public abstract void Onclick();
}