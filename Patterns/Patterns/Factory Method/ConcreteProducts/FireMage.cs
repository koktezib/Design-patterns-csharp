using Patterns.Patterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.Factory_Method.ConcreteProducts
{
    internal class FireMage : Mage
    {

        public override void CastSpell()
        {
            Console.WriteLine("Fire spell");
        }
    }
}
