using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurace
{
    internal class Food
    {
        public string name;
        public int price;
        public string type;

        public Food(string jmeno, int cena, string typ)
        {
            name = jmeno;
            price = cena;
            type = typ;
        }
    }
}
