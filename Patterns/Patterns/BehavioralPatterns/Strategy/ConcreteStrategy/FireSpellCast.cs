using Patterns.Patterns.BehavioralPatterns.Strategy.AbstractStrategy;

namespace Patterns.Patterns.BehavioralPatterns.Strategy.ConcreteStrategy;

public class FireSpellCast : ICastable
{
    public void Cast()
    {
        Console.WriteLine("FireSpellCast");
    }
}