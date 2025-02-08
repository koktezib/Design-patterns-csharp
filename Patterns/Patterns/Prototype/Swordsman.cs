namespace Patterns.Patterns.Prototype;

public class Swordsman(int damage, string name) : IUnit
{
    public int Damage = damage;
    public string Name = name;
    
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