using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns.Factory_Method
{
    internal class FrostMageCreator : MageCreator
    {
        public FrostMageCreator(string name) : base(name) { }

        public override Mage Create()
        {
            return new FrostMage();
        }
    }
}
