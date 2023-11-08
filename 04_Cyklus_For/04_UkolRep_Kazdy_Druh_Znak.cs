namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "zadřeš on i co onsemnaí";

            /*
             * Podmínka je nastavena na délku řetězce a jelikož je počet znaků o 1 větší než indexování znaků, které začíná 0, pak nám podmínka funguje.
             * Po každén průchodu cyklem zvyšuji i o 2 a díky tomu vypisuji pouze každý druhý znak.
             */
            for (int i = 0; i < text.Length; i+=2)
            {
                Console.WriteLine(text[i]);
            }

        }
    }
}