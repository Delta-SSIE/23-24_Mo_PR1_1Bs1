using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicnost_poly_abs
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public override void Information()
        {
            Console.WriteLine($"My name is {Name} and i do *haf haf*");
        }
    }
}
