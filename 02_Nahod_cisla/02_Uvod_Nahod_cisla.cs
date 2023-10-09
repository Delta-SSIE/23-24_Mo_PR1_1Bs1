namespace Nahod_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba generátoru náhodných čísel
            Random generator_nahod = new Random();

            //Generování náhodných čísel
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.WriteLine(generator_nahod.Next());
            Console.ReadKey();

            Console.Clear();
            //Generátor čísel s rozsahem
            int cisloA = generator_nahod.Next(1,3);
            Console.WriteLine(cisloA);
        }
    }
}