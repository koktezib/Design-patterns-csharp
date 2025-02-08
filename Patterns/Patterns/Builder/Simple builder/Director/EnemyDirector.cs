using Patterns.Patterns.Builder.Simple_builder.AbstractBuilder;
using Patterns.Patterns.Builder.Simple_builder.Product;

namespace Patterns.Patterns.Builder.Simple_builder.Director;

public class EnemyDirector(IEnemyBuilder enemyBuilder)
{
    private readonly IEnemyBuilder _enemyBuilder = enemyBuilder;

    public Enemy BuildSwordsman()
    {
        _enemyBuilder.SetName("Swordsman");
        _enemyBuilder.SetHealth(10);
        _enemyBuilder.SetDamage(5);
        _enemyBuilder.SetWeaponType(WeaponType.Sword);
        return _enemyBuilder.Build();
    }
    
    public Enemy BuildArcher()
    {
        _enemyBuilder.SetName("Archer");
        _enemyBuilder.SetHealth(10);
        _enemyBuilder.SetDamage(5);
        _enemyBuilder.SetWeaponType(WeaponType.Bow);
        return _enemyBuilder.Build();
    }
    
}