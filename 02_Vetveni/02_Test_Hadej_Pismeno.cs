namespace test_hadej_pismeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Napiš mi slovo!");
            string slovo = Console.ReadLine();

            int delka_slova = slovo.Length;
            int cislo = generator.Next(1, delka_slova + 1);

            Console.WriteLine($"Hádej ve slově písmeno na pozici {cislo}!");
            char pismeno = Console.ReadKey().KeyChar;

            if (pismeno == slovo[cislo-1])
            {
                Console.WriteLine("Správně!");
            } else
            {
                Console.WriteLine("Špatně");
            }


            
        }
    }
}