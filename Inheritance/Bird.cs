using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool Flies;
        public bool Aquatic;
        public string Size;
        public string ActiveHours;

        public Bird(bool flies, bool aquatic, string size, string activeHours) 
        {
            Flies = flies;
            Aquatic = aquatic;
            Size = size;
            ActiveHours = activeHours;
        }
    }
}
