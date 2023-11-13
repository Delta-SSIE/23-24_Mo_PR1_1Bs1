namespace namaluj_ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi délku stran čtverce");
            int strana = int.Parse(Console.ReadLine());

            for (int i = 0; i < strana; i++)
            {
                for (int n = 0; n < strana; n++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}