using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Patterns.Factory_Method
{
    public abstract class MageCreator
    {
        public string Name { get; set; }

        public MageCreator(string name) {
            Name = name;
        }

        public abstract Mage Create();
    }
}
