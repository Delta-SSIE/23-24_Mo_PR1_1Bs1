namespace delitelnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo ");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo % 2 == 0 && cislo % 3 == 0)
            {
                Console.WriteLine("Číslo je dělitelné 2 a 3");
            } else if (cislo % 2 == 0)
            {
                Console.WriteLine("Číslo je dělitelné 2");
            } else if (cislo % 3 == 0)
            {
                Console.WriteLine("Číslo je dělitelné 3");
            }
        }
    }
}