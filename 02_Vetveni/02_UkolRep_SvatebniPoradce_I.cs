using System.Runtime.InteropServices;

namespace svatbeniporad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nastavte si proměnné
            bool jeMlady = true;
            bool jeHezky = false;
            bool jeBohaty = true;

            // tuto podmínku je třeba doplnit
            if (jeHezky == true ||(jeBohaty == true && jeMlady == false))
            // zde končí úpravy
            {
                Console.WriteLine("Vezmi si ho!");
            }
            else
            {
                Console.WriteLine("Toho si neber!");
            }


        }
    }
}