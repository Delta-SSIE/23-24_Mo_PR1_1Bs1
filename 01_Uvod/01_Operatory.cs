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

            //Replit úkol Převod času
            Console.Write("Zadej mi počet sekund a já je převedu na hodiny a minuty: ");
            int cas = int.Parse(Console.ReadLine());
            int sekundy;
            int minuty;
            int hodiny;
            sekundy = cas % 60;
            minuty = ((cas-sekundy) % 3600)/60;
            hodiny = (cas-sekundy-(minuty*60)) / 3600;
            Console.WriteLine(sekundy + " sekund a " + minuty + " minut a " + hodiny + " hodin");

            //Přiřazovací operátory
            int a = 3;
            int b = 2;
            //Delší zápis
            a = a * 2;
            b = b + 2;
            //Zkrácený zápis, pomocí přiřazovacího operátoru
            a *= 2;
            b += 2;

            //Porovnávací operátory
            int k = 200;
            int p = 500;
            //Ověření podmínky, pokud platí vypíše se TRUE a pokud neplatí vypíše se FALSE
            Console.WriteLine(k < p);
            Console.WriteLine(k > p);


        }
    }
}