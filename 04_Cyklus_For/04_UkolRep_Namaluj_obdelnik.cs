namespace namaluj_obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Řekni mi délku strany a (výška)");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Řekni mi délku strany b (šířka)");
            int b = int.Parse(Console.ReadLine());

            //Vnější cyklus se stará o řádky (neboli o výšku) obdelníka
            for (int i = 0; i < a; i++)
            {
                //Vnitřní cyklus se stará o sloupce (neboli o šířku) obdelníka
                for (int j = 0; j < b; j++)
                {
                    Console.Write('#');
                }

                Console.WriteLine();
            }

        }
    }
}