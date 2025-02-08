using Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.Product;

namespace Patterns.Patterns.CreationalPatterns.Builder.Simple_builder.AbstractBuilder;

public interface IEnemyBuilder
{
    public void SetName(string name);
    public void SetHealth(int health);
    public void SetDamage(int damage);
    public void SetWeaponType(WeaponType weaponType);
    
    public Enemy Build();
}