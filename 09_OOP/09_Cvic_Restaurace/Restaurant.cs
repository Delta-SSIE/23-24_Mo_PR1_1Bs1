using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurace
{
    internal class Restaurant
    {
        public string name;
        public Food[] foodlist;

        public Restaurant(string nazev)
        {
            name = nazev;
    
        }

        public void VypisJidlo()
        {
            foreach (Food jidlo in this.foodlist)
            {
                if(jidlo.name != "X")
                {
                    Console.WriteLine($"{jidlo.name} stojí {jidlo.price} korun a jedná se o {jidlo.type} jídlo.");
                }
            }
        }

        public void PridejJidlo()
        { 
            Array.Resize(ref foodlist, foodlist.Length + 1);
            foodlist[foodlist.Length - 1] = new Food("Houska", 120, "Veganské");
        }

        public void OdeberJidlo()
        {
            string nazev_odeber = "Lilek";
            foreach (Food jidlo in foodlist)
            {
                if(jidlo.name == nazev_odeber)
                {
                    jidlo.name = "X";
                }
            }
        }
    }
}
