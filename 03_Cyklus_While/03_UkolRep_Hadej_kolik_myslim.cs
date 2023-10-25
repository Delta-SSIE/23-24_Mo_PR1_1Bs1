namespace Hadej_kolik_myslim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random cisla = new Random();
            //Náhodné číslo, co si myslí
            int cislo = cisla.Next(1, 101);
            //hráčův odhad
            int odhad = 0;
            //počitadlo kol
            int kolo = 0;

            do
            {
                //Zvýšení počítadla o jedna.
                kolo++;
                Console.WriteLine($"{kolo}. Kolo");
                Console.WriteLine("Napiš číslo: ");
                //Cyklus na odchycení uživatelova vstupu
                while(!int.TryParse(Console.ReadLine(),out odhad))
                {
                    Console.WriteLine("Zadej číslo a ne jiný datový typ!");
                }
                //Zjištuje jestli má přidat, či ubrat
                if (cislo == odhad)
                {
                    Console.WriteLine($"Jupí hotovo! Uhádl jsi číslo v {kolo}. kole");
                } else if (cislo < odhad)
                {
                    Console.WriteLine("Uber!");
                } else
                {
                    Console.WriteLine("Přidej!");
                }

            } while (odhad != cislo);
        }
    }
}