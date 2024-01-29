namespace Dve_diagonaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zde vytvořte proměnnou typu 2D pole řetězců o rozměrech 5 x 5 prvků
            string[,] diagonaly = new string[5, 5];
            // promennou nazvete diagonaly

            // uložt do všechn prvků pole mezery, jen do diagonál vložte #
            for (int y = 0; y < diagonaly.GetLength(0); y++)
            {
                for (int x = 0; x < diagonaly.GetLength(1); x++)
                {
                    diagonaly[y, x] = " ";
                }
            }


            for (int i = 0; i < diagonaly.GetLength(0); i++)
            {
                diagonaly[i, i] = "#";
                diagonaly[i, diagonaly.GetLength(0)-i-1] = "#";
            }

            //zde pole vypíšeme - vypisovací metoda už je připravena
            Vypis2DPole(diagonaly);

        }

        public static void Vypis2DPole(string[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
