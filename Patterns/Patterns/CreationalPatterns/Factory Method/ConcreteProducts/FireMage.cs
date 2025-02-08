using Patterns.Patterns.CreationalPatterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteProducts
{
    public class FireMage : Mage
    {

        public override void CastSpell()
        {
            Console.WriteLine("Fire spell");
        }
    }
}
