namespace Uvod_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cyklus While

            int x = 0;

            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            //Cyklus robot-nakupčí coly
            Random mince = new Random();
            int cena_cola = 40;
            int automat = 0;

            while(automat < cena_cola)
            {
                int nahod_mince = mince.Next(1, 10);
                Console.WriteLine($"Robot vhodil minci hodnoty {nahod_mince}!");
                automat += nahod_mince;
                Console.WriteLine($"V automatu je aktuálně {automat} peněz.");
                Console.ReadKey();
            }

            Console.WriteLine($"Robot vzal colu a sebral zbytek mincí: {automat - cena_cola}");
        }
    }
}