namespace _2Dpole_Zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole s čísly
            int[,] cisla = { { 1, 4, 2, 0}, { 3, 6, 8, 1 }, {5, 8, 9, 5} };

            //Výpis z pole
            Console.WriteLine(cisla[0, 1]);
            Console.WriteLine(cisla[1, 0]);

            //Změna hodnoty v poli
            Console.WriteLine(cisla[0, 0]);
            cisla[0, 0] = 8;
            Console.WriteLine(cisla[0, 0]);

            Console.WriteLine();

            //Výpis pomocí foreach
            foreach (int cislo in cisla)
            {
                Console.Write($"{cislo} ");
            }

            Console.WriteLine();

            //Výpis počtu řádků a sloupců pole
            Console.WriteLine(cisla.GetLength(0));
            Console.WriteLine(cisla.GetLength(1));
            Console.WriteLine();

            //Výpis pomocí for cyklů
            for (int i = 0; i < cisla.GetLength(0); i++)
            {
                for (int j = 0; j < cisla.GetLength(1); j++)
                {
                    Console.Write(cisla[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Deklarace pole bez jeho naplnění

            string[,] jmena = new string[2, 3];

            jmena[0, 2] = "Karel";
            jmena[1, 2] = "Jan";
            Console.WriteLine(jmena[0, 2]);

            foreach (string jmeno in jmena)
            {
                Console.Write(jmeno + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < jmena.GetLength(0); i++)
            {
                for (int j = 0; j < jmena.GetLength(1); j++)
                {
                    Console.Write(jmena[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}