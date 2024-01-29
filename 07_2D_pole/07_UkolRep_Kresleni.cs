namespace _2D_Kresleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
{
            {  true, false, false,  true, false, false,  true},
            { false,  true, false,  true, false,  true, false},
            { false, false,  true,  true,  true, false, false},
            { false, false, false,  true, false, false, false},
        };

            VykresliPole(mapa,"#","_");
            Console.WriteLine();
            VykresliPole(mapa);
        }

        static void VykresliPole(bool[,] mapa, string pravda = "#", string nepravda = " ")
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (mapa[i,j] == true)
                    {
                        Console.Write(pravda);
                    } else
                    {
                        Console.Write(nepravda);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}