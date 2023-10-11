namespace KNP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random hra = new Random();

            int cislo = hra.Next(1,4);

            switch (cislo)
            {
                case 1:
                    Console.WriteLine("Kámen");
                    break;
                case 2:
                    Console.WriteLine("Nůžky");
                    break;
                case 3:
                    Console.WriteLine("Papír");
                    break;
            }

        }
    }
}