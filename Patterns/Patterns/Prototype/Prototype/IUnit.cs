namespace Patterns.Patterns.Prototype.Prototype;

public interface IUnit
{
    IUnit Clone();
    void Attack();
    
    void ChangeName(string name);
}