using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns.Factory_Method
{
    internal class FireMageCreator : MageCreator
    {
        public FireMageCreator(string name) : base(name) { }
        public override Mage Create()
        {
            return new FireMage();
        }
    }
}
