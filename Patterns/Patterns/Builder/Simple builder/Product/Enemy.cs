namespace Patterns.Patterns.Builder.Simple_builder.Product;

public class Enemy
{
    public string? Name;
    public int Health;
    public int Damage;
    public WeaponType Weapon;

    public void PrintStats()
    {
        Console.WriteLine($"Unit Name: {Name}, health: {Health}, damage: {Damage}, weapon: {Weapon}");
    }
}

public enum WeaponType
{
    Sword,
    Bow,
    Staff,
}