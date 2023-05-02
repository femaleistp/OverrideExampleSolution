using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExampleProject
{
    internal class Animal
    {
        public virtual string MakeSound()
        {
            return "Animal sound...";
        }
    }
}
