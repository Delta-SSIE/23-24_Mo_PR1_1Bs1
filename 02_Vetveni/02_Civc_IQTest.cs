namespace iq_testt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Kolik je 2 + 4");
            int vysledek = int.Parse(Console.ReadLine());
            if (vysledek == 6)
            {
                score = score + 5;
            } else
            {
                score = score - 3;
            }

            Console.WriteLine("Jakým písmenem začíná abeceda?");
            string pismeno = Console.ReadLine();
            if (pismeno == "a" || pismeno == "A")
            {
                score += 5;
            } else
            {
                score -= 3;
            }
        }
    }
}