namespace pred_pikolou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cyklus for pro cvičení Před pikolou viz. Replit
            /*
             * Na začátku se i nastaví na hodnotu 10
             * Kontroluje se jestli je i menší, či rovno 200 do té doby se cyklus opakuje.
             * Proměná i se po každém průchodu cyklu zvýší o 10.
             */
      
            for (int i = 10; i <= 200; i+=10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Už jdu!");
        }
    }
}