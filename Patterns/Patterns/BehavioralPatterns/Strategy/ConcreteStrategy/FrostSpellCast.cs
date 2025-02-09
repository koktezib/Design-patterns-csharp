using Patterns.Patterns.BehavioralPatterns.Strategy.AbstractStrategy;

namespace Patterns.Patterns.BehavioralPatterns.Strategy.ConcreteStrategy;

public class FrostSpellCast : ICastable
{
    public void Cast()
    {
        Console.WriteLine("FrostSpellCast");
    }
}