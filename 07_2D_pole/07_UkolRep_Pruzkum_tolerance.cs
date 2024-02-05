using System.Dynamic;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sousedi = { "Merkuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {
            {  true, false, false, false,  true,  true, true,  true },
            {  true,  true,  true,  true,  true, false, true,  true },
            {  true,  true, false,  true,  true,  true, true, false },
            { false,  true,  true,  true,  true, false, true,  true },
            {  true, false, false,  true, false, false, true, false },
            {  true, false, false,  true,  true, false, true, false },
            {  true, false, false,  true, false, false, true,  true },
            };

            Console.WriteLine(sousedi[Nej_pocet_true(vysledky, 1, 0, true)]);
            Console.WriteLine(respondenti[Nej_pocet_true(vysledky, 0, 1, true)]);
            Console.WriteLine(respondenti[Nej_pocet_true(vysledky, 0, 1, false)]);

        }

        static int Nej_pocet_true(bool[,] pole, int radky, int sloupec, bool roz)
        {
            int pocitadlo = 0;
            int max_true = 0;
            int index_max = 0;

            for (int i = 0; i < pole.GetLength(radky); i++)
            {
                for (int j = 0; j < pole.GetLength(sloupec); j++)
                {
                    if (radky == 0)
                    {
                        if (pole[i,j] == roz)
                        {
                            pocitadlo++;
                        }
                    } else if (pole[j, i] == roz)
                    {
                        pocitadlo++;
                    }
                }
                if (pocitadlo > max_true)
                {
                    max_true = pocitadlo;
                    index_max = i;
                }
                pocitadlo = 0;
            }
            return index_max;
        }
    }
}