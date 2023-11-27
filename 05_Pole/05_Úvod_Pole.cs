namespace pole_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole "cisel" s předem zdanými 6 hodnotami
            int[] cisel = {3, 5, 100, 20, 4000, 52};

            //Výpis z prvku z pole v hranatých závorkách je vždy index daného prvku v rámci pole.
            Console.WriteLine(cisel[0]);
            Console.WriteLine(cisel[3]);

            //Přepis hodnoty v pole "cisel" na indexu 0
            cisel[0] = 15;
            
            //Výpis z pole
            Console.WriteLine(cisel[0]);

            //Metoda Sort pro seřazení pole
            Array.Sort(cisel);
            //Výpis z pole
            Console.WriteLine(cisel[5]);

            //Použití For cyklu pro průchod pole a vypsání jeho hodnot
            Console.WriteLine("Výpis z pole: ");
            for (int i = 0; i < cisel.Length; i++)
            {
                Console.Write(cisel[i] + " ");
            }
            Console.WriteLine();

            //Použití foreach cyklu pro průchod pole a vypsání hodnot
            Console.WriteLine("Výpis z pole vol. 2: ");
            foreach (int a in cisel)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Deklarace pole o délce 10
            string[] jmena = new string[10];
            //Výpis délky pole
            Console.WriteLine(jmena.Length);

            //Deklarace pole "adresa" o dané délce 2 s již vloženými hodnotami
            string[] adresa = new string[2] { "Na Kamenici", "U hotelu Praha" };

        }
    }
}