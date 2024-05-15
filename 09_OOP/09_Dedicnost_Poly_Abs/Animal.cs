using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicnost_poly_abs
{
    internal class Animal
    {
        public string Name
        { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Zzzzzzz");
        }

        public virtual void Information()
        {
            Console.WriteLine($"My name is {Name} and i do *sounds*");
        }
    }
}
