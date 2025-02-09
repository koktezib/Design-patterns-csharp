using Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observable;
using Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observer;

namespace Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Concrete_Observer;

public class HealthBar : IObserver
{
    public HealthBar(IObservable observable)
    {
        observable.Attach(this);
    }
    public void Update()
    {
        Console.WriteLine("Current health");
    }
}