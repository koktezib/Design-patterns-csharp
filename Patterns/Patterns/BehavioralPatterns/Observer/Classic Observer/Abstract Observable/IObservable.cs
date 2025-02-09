using Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observer;

namespace Patterns.Patterns.BehavioralPatterns.Observer.Classic_Observer.Abstract_Observable;

public interface IObservable
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}