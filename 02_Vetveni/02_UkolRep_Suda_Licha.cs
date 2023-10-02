namespace suda_licha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo a já ti řeknu, jestli je sudé, či liché?");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo % 2 == 0)
            {
                Console.WriteLine("Číslo je sudé!");
            } else
            {
                Console.WriteLine("Číslo je liché");
            }
        }
    }
}