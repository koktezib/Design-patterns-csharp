using Patterns.Patterns.CreationalPatterns.Factory_Method.AbstractProduct;

namespace Patterns.Patterns.CreationalPatterns.Factory_Method.Creator
{
    public abstract class MageCreator(string name)
    {
        public abstract Mage Create();
    }
}
