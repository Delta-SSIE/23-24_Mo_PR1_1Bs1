using System.Security.Cryptography.X509Certificates;

namespace soucet_zadanych4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Pomocná porměná pro ukládání součtu
            int soucet = 0;

            //Do While – nejdříve tělo, pak kontrola s podmínkou
            do
            {
                Console.WriteLine("Zadej číslo");
                x = int.Parse(Console.ReadLine());
                //K hodnotě proměné soucet přičtu hodnotu x
                soucet += x;

            } while (x != 0);

            //Výpis výsledku
            Console.WriteLine($"Součet zadaných hodnot je {soucet}");
        }
    }
}