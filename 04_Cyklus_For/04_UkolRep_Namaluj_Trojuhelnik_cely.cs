namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyska = 20;

            //Vnější for cyklus na vypsání řádků (výšky)
            for (int i = 0; i < vyska; i++)
            {
                //For cyklus vnitřní na řešení levé strany trojuhelníku
                for (int j = 0; j < vyska; j++)
                {
                    if(j+1 > vyska - i)
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write(' ');
                    }
                    
                }

                //Vnitřní linka trojuhelníku
                Console.Write('#');

                //For cyklus vnitřní na řešení pravé strany trojuhelníku
                for (int n = 0; n < vyska; n++)
                {
                   if (n < i)
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write(' ');
                    }
                }

                //Zalomení řádku
                Console.WriteLine();

            }
        }
    }
}