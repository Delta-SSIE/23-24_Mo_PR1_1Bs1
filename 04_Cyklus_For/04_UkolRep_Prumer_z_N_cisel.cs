namespace Prumer_zN_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proměná na udržení počtu průchodů.
            int n;
            //proměná pro ukládání součtu čísel vložených.
            double soucet = 0;
            //TryParse pro zadání počtu průchodů s odchycením chyby uživatele
            Console.WriteLine("Řekni kolik čísel budeš chtít vložit?");
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Zadej číslo a nic jiného!");
            }

            //Výpis kolikrát se cyklus opakuje!
            Console.WriteLine($"Budeme načítat {n} čísel");

            //For cyklus s i začínající na 1, kvůli výpisu. Podmínka má tedy nastavené menší a rovno, aby počet průchodů byl stejný, jako byl zadán.
            for (int i = 1; i <= n; i++)
            {
                double a;
                Console.WriteLine($"Zadej {i}.číslo");
                ///TryParse na double!
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Zadej číslo a nic jiného!");
                }
                soucet += a;
            }

            //Výpis:
            Console.WriteLine($"Průměrná hodnota vloženého čísla byla {soucet/n}");
        }
    }
}