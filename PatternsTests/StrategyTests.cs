using Patterns.Patterns.BehavioralPatterns.Strategy.AbstractStrategy;
using Patterns.Patterns.BehavioralPatterns.Strategy.ConcreteStrategy;

namespace PatternsTests;

[TestFixture]
public class StrategyTests
{
    private ICastable _fireSpell;
    private ICastable _frostSpell;

    [SetUp]
    public void Setup()
    {
        _fireSpell = new FireSpellCast();
        _frostSpell = new FrostSpellCast();
    }

    [Test]
    public void FireSpellCast_ShouldPrintCorrectMessage()
    {
        using var consoleOutput = new ConsoleOutput();
        _fireSpell.Cast();
        Assert.That(consoleOutput.GetOutput(), Is.EqualTo("FireSpellCast\r\n"));
    }

    [Test]
    public void FrostSpellCast_ShouldPrintCorrectMessage()
    {
        using var consoleOutput = new ConsoleOutput();
        _frostSpell.Cast();
        Assert.That(consoleOutput.GetOutput(), Is.EqualTo("FrostSpellCast\r\n"));
    }
}

public class ConsoleOutput : IDisposable
{
    private readonly System.IO.StringWriter _stringWriter;
    private readonly System.IO.TextWriter _originalOutput;

    public ConsoleOutput()
    {
        _stringWriter = new System.IO.StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_stringWriter);
    }

    public string GetOutput()
    {
        return _stringWriter.ToString();
    }

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _stringWriter.Dispose();
    }
}

