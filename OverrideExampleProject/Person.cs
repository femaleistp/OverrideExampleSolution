using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExampleProject
{
    internal class Person : Animal
    {
        public override string MakeSound()
        {
            return "Person sound...";
        }
    }
}
