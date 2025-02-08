using Patterns.Patterns.CreationalPatterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteProducts
{
    public class FrostMage : Mage
    {
        public override void CastSpell()
        {
            Console.WriteLine("Frost spell");
        }
    }
}
