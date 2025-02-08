using Patterns.Patterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.Factory_Method.ConcreteProducts
{
    internal class FrostMage : Mage
    {
        public override void CastSpell()
        {
            Console.WriteLine("Frost spell");
        }
    }
}
