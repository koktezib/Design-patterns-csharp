using Patterns.Patterns.CreationalPatterns.Factory_Method.AbstractProduct;
using Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteProducts;
using Patterns.Patterns.CreationalPatterns.Factory_Method.Creator;

namespace Patterns.Patterns.CreationalPatterns.Factory_Method.ConcreteCreators
{
    public class FireMageCreator(string name) : MageCreator(name)
    {
        public override Mage Create()
        {
            return new FireMage();
        }
    }
}
