namespace delka_slov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej 1. slovo");
            string slovoA = Console.ReadLine();
            Console.WriteLine("Zadej 2. slovo");
            string slovoB = Console.ReadLine();

            if (slovoA.Length == slovoB.Length)
            {
                Console.WriteLine($"\"{slovoA}\" a \"{slovoB}\" jsou stejně dlouhé!");
            } else if (slovoA.Length > slovoB.Length)
            {
                Console.WriteLine($"\"{slovoA}\" je delší než \"{slovoB}\"!");
            } else
            {
                Console.WriteLine($"\"{slovoB}\" je delší než \"{slovoA}\"!");
            }
        }
    }
}