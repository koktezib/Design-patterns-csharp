namespace Patterns.Patterns.AbstractFactory;

public class WinButton(string text, string name) : Button(text, name)
{
    public override void Onclick()
    {
        Console.WriteLine(Text + " Windows");
    }
}