using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns.Factory_Method
{
    public abstract class MageCreator(string name)
    {
        public string Name { get; set; } = name;

        public abstract Mage Create();
    }
}
