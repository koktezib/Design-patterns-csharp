namespace Patterns.Patterns.Prototype;

public interface IUnit
{
    IUnit Clone();
    void Attack();
    
    void ChangeName(string name);
}