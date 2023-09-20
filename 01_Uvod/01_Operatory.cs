namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;

            //Inkriminace (fake)
            x = x + 1;
            //Skutečná inkriminace
            x++;

            //Deinkriminace (fake)
            y = y - 1;
            //skutečná deinkriminace
            y--;

            //Modolus (operátor po zobrazení zbytku po dělení číslem)
            Console.WriteLine(7 % 2);
            Console.WriteLine(14 % 3);
            Console.WriteLine("Zbytek po dělení čísla 18 číslem 7 je " + (18 % 7) + ". To znamená, že pro celočíselné dělení je nejbližší číslo od 18 " + (18-(18%7)));


            Console.WriteLine("hodnota x je "+ x + ". Hodnota y je " + y + "." );
        }
    }
}