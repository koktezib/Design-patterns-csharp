using Patterns.Patterns.Prototype.Prototype;

namespace Patterns.Patterns.Prototype.ConcretePrototype;

public class Archer(int damage, string name, int range) : IUnit
{
    public int Damage = damage;
    public string Name = name;
    public int Range = range;
    
    public IUnit Clone()
    {
        return this.MemberwiseClone() as IUnit;
    }

    public void Attack()
    {
        Console.WriteLine(Name + "attacked");
    }

    public void ChangeName(string name)
    {
        Name = name;
    }
}