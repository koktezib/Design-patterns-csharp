using Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observable;
using Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observer;

namespace Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Concrete_Observable;

public class PlayerHealth : IObservable
{
    private List<IObserver> Observers { get; set; } = [];
    
    public void Attach(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in Observers)
            observer.Update();
    }
}