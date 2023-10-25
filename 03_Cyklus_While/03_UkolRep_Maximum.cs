namespace Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int vstup = 0;

            do
            {
                Console.WriteLine("Zadej mi číslo (pro ukončení zadej 0, či menší)");
                vstup = int.Parse(Console.ReadLine());
                if (vstup > max)
                {
                    max = vstup;
                }

            } while (vstup > 0);

            if (max != 0)
            {
                Console.WriteLine($"Největší číslo je {max}");
            } else
            {
                Console.WriteLine("Nebylo zadáno žádné číslo!");
            }
           
        }
    }
}