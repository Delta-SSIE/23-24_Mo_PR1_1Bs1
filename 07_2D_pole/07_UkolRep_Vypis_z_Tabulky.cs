namespace Vypis_z_tabulky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla = {
            {1, 0, 10, 4, 7},
            {2, 2, 3, 4, 2},
            {6, 5, 4, 3, 2}
        };

            VypisTabulku(cisla);

            Console.WriteLine();

            int[,] cisla2 = {
            {1, 0, 10, 4},
            {2, 2, 3, 4},
            {6, 5, 4, 3},
            {12, 0, 0, -1}
        };

            VypisTabulku(cisla2);
        }
        static void VypisTabulku(int[,] tabulka)
        {
            for (int i = 0; i < tabulka.GetLength(0); i++)
            {
                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    Console.Write("--");
                }
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < tabulka.GetLength(1); j++)
                {
                    
                    Console.Write(tabulka[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            for (int x = 0; x < tabulka.GetLength(1); x++)
            {
                Console.Write("--");
            }
            Console.WriteLine();

        }
    }

}