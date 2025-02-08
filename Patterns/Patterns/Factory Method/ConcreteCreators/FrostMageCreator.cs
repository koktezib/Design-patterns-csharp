﻿using Patterns.Patterns.Factory_Method.AbstractProduct;
using Patterns.Patterns.Factory_Method.ConcreteProducts;
using Patterns.Patterns.Factory_Method.Creator;

namespace Patterns.Patterns.Factory_Method.ConcreteCreators
{
    internal class FrostMageCreator(string name) : MageCreator(name)
    {
        public override Mage Create()
        {
            return new FrostMage();
        }
    }
}
