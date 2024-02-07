namespace Senatni_volby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kandidati = { "Alena", "Božena", "Cecílie", "Dana", "Eva", "Filoména", "Gertruda", "Hildegarda" };
            int[,] hlasy =
            {
            {0,2,1,0,0,0,1,1},
            {0,0,1,1,2,0,0,0},
            {0,0,1,0,2,1,0,0},
            {1,1,0,2,0,1,0,0},
            {0,0,1,2,1,0,0,1},
            {0,2,1,0,1,1,0,0},
            {0,1,1,1,0,1,2,1},
            {0,0,1,0,0,2,0,0},
            {0,0,0,0,2,1,0,0},
            {0,0,1,1,0,1,2,0},
            {1,0,2,0,0,1,1,1},
            {1,2,1,1,0,0,0,1},
            {0,0,2,1,0,1,0,0},
            {0,0,0,0,0,0,0,2},
            {2,0,1,0,0,1,0,0},
            {1,0,0,0,0,2,0,0},
            {0,0,0,1,2,0,0,0},
            {0,1,1,0,2,0,0,1},
            {1,2,1,0,1,1,1,0},
            {0,1,2,1,0,1,0,0},
            {1,1,1,2,0,0,0,1},
            {0,0,1,2,0,1,1,1},
            {0,2,1,0,1,1,0,0},
            {0,1,2,0,1,1,0,0},
            {0,2,1,0,1,0,0,0},
            {0,2,0,0,1,1,1,0},
            {0,2,0,1,0,1,0,1},
            {0,2,1,0,0,0,0,0},
            {0,0,2,1,1,0,0,1},
            {0,0,1,2,0,1,0,0},
            {0,0,1,1,0,2,0,0},
            {0,1,1,1,1,0,0,2},
            {0,1,1,2,1,1,0,0},
            {2,1,0,1,0,1,0,0},
            {0,1,1,1,0,1,1,2},
        };
            int[] soucet_hlas = { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < hlasy.GetLength(0); i++)
            {
                for (int j = 0; j < hlasy.GetLength(1); j++)
                {
                    if (hlasy[i,j] == 2)
                    {
                        soucet_hlas[j]++;
                    }
                }
            }

            for (int i = 0; i < soucet_hlas.Length; i++)
            {
                Console.WriteLine($"{kandidati[i]} získal {soucet_hlas[i]}");
            }

            int index_kand1 = 0;
            int index_kand2 = 0;

            for (int i = 1; i < soucet_hlas.Length; i++)
            {
                if (soucet_hlas[i] > soucet_hlas[index_kand1])
                {
                    index_kand1 = i;
                } else if (soucet_hlas[i] > soucet_hlas[index_kand2])
                {
                    index_kand2 = i;
                }
            }

            Console.WriteLine($"Do druhého kola postupuje: {kandidati[index_kand1]} a {kandidati[index_kand2]}");

            int[] druhe_kolo = { 0, 0 };

            for (int i = 0; i < hlasy.GetLength(0); i++)
            {
                if (hlasy[i,index_kand1] != hlasy[i, index_kand2])
                {
                    if (hlasy[i,index_kand1] > hlasy[i,index_kand2])
                    {
                        druhe_kolo[0]++;
                    } else
                    {
                        druhe_kolo[1]++;
                    }
                }
            }

            if (druhe_kolo[0] > druhe_kolo[1])
            {
                Console.WriteLine($"Vyhrál kandidát: {kandidati[index_kand1]} s počtem hlasů {druhe_kolo[0]} soupeř měl hlasů: {druhe_kolo[1]}");
            } else
            {
                Console.WriteLine($"Vyhrál kandidát: {kandidati[index_kand2]} s počtem hlasů {druhe_kolo[1]} soupeř měl hlasů: {druhe_kolo[0]}");
            }
        }
    }
}