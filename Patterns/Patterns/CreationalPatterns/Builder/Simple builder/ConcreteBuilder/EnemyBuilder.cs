using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.AbstractBuilder;
using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.Product;

namespace Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.ConcreteBuilder;

public class EnemyBuilder : IEnemyBuilder
{
    private string? _name;
    private int _health;
    private int _damage;
    private WeaponType _weaponType;
    
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetHealth(int health)
    {
        _health = health;
    }

    public void SetDamage(int damage)
    {
        _damage = damage;
    }

    public void SetWeaponType(WeaponType weaponType)
    {
        _weaponType = weaponType;
    }

    public Enemy Build()
    {
        var enemy = new Enemy
        {
            Name = _name ?? "Default enemy name",
            Damage = _damage,
            Health = _health,
            Weapon = _weaponType
        };

        Reset();
        return enemy;
    }

    private void Reset()
    {
        _name = null;
        _health = 0;
        _damage = 0;
        _weaponType = default;
    }
}