namespace Nahodne_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VykresliPole(VytvorMapu(5, 10, 30));
        }
        static void VykresliPole(bool[,] mapa, string pravda = "#", string nepravda = " ")
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (mapa[i, j] == true)
                    {
                        Console.Write(pravda);
                    }
                    else
                    {
                        Console.Write(nepravda);
                    }
                }
                Console.WriteLine();
            }
        }
        static bool[,] VytvorMapu(int vyska, int sirka, int pocetminci)
        {
            Random generator = new Random();

            bool[,] pole = new bool[vyska, sirka];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = false;
                }
            }

            for (int i = 0; i < pocetminci; i++)
            {
                int nah_vyska = generator.Next(0, vyska);
                int nah_sirka = generator.Next(0, sirka);
                while (pole[nah_vyska, nah_sirka] == true)
                {
                        nah_vyska = generator.Next(0, vyska);
                    nah_sirka = generator.Next(0, sirka);
                }
                pole[nah_vyska, nah_sirka] = true;
            }

            return pole;
        }
    }
}