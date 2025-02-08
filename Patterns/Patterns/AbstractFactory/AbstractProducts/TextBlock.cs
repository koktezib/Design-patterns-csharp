namespace Patterns.Patterns.AbstractFactory.AbstractProducts;

public class TextBlock (string text, string name, string fontFamily)
{
    public string Text { get; set; } = text;
    public string Name {get; set;} = name;
    public string FontFamily {get; set;} = fontFamily;
}