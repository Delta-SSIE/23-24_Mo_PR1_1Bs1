namespace pyramida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyska = 25;
            int pocet = 0;
            //dál pokračujte vy

            for (int i = 1; i <= vyska; i++)
            {
                pocet += i * i;
            }

            //zde končí váš kód
            Console.WriteLine($"Na stavbu pyramidy výšky {vyska} je potřeba {pocet} kostek.");
        }
    }
}