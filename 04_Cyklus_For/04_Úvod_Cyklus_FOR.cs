namespace for_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cyklus for
            //Cyklus for funguje na principu 3 tvrzení. 
            /* 
             1. tvrzení v příkladu iniciuje i a nastaví jeho hodnotu na 0. (Toto tvrzení se spustí pouze jednou a to při spuštění cyklu)
             2. tvrzení je podmínka, která se vždy ověřuje a dokud platí, tak se cyklus opakuje. V našem případě se ověřuje, že i je menší než 10. (kontroluje se i po prvním spuštění).
             3. tvrzení je to, co se vždy stane po průchodu těla cyklus. V našem případě se i zvýšší o 1. 
             */
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}. Hello world!");
            }

            //Cyklus for s příkladem, kdy se i chová jinak

            for (int i = 2; i <= 50; i*=2)
            {
                Console.WriteLine($"{i}. Hello world!");
            }
        }
    }
}