using Patterns.Patterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.Factory_Method.Creator
{
    public abstract class MageCreator(string name)
    {
        public abstract Mage Create();
    }
}
