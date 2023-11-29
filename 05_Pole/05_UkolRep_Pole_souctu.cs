namespace Pole_souctu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();

            int[] cisla = new int[10];

            for (int i = 0; i < cisla.Length; i++)
            {
                cisla[i] = gen.Next(0, 100);
                Console.WriteLine(cisla[i]);
            }

            Console.WriteLine();
            int[] pole_soucet = new int[cisla.Length];

            /* Řešení s použítí pomocné proměné součet
             * int soucet = 0;
            for (int i = 0; i < pole_soucet.Length; i++)
            {
                soucet += cisla[i];
                pole_soucet[i] = soucet;
            }
            */

            //Řešení s dvěma cykly
            for (int i = 0; i < pole_soucet.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    pole_soucet[i] += cisla[j];
                }
            }

            //Výpis pole pole_soucet
            foreach (int cislo in pole_soucet)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}