using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns.Factory_Method
{
    internal class FrostMage : Mage
    {
        public override void CastSpell()
        {
            Console.WriteLine("Frost Spell");
        }
    }
}
