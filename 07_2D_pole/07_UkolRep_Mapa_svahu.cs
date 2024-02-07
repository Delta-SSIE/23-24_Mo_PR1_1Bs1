using System.Dynamic;

namespace Mapa_svahu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zde je použijte a zavolejte na ně výpis
            VypisPole(Svah(20)); //až bude hotovo, odkomentujte si
            Console.WriteLine();
            VypisPole(SikmySvah(20)); //až bude hotovo, odkomentujte si

            //zde jsou volání pro level 3
            //VypisPole(Svah(4, "jih"));
            //VypisPole(Svah(4, "zapad"));
        }

        //zde vytvořte vaše metody
        static int[,] Svah (int rozmer)
        {
            int[,] svah = new int[rozmer, rozmer];

            for (int i = 0; i < svah.GetLength(0); i++)
            {
                for (int j = 0; j < svah.GetLength(1); j++)
                {
                    svah[i, j] = j;
                }
            }

            return svah;
        }

        static int[,] SikmySvah(int rozmer)
        {
            int[,] svah = new int[rozmer, rozmer];

            for (int i = 0; i < svah.GetLength(0); i++)
            {
                for (int j = 0; j < svah.GetLength(1); j++)
                {
                    svah[i, j] = j+i;
                }
            }

            return svah;
        }

        //výpis je hotov
        public static void VypisPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}