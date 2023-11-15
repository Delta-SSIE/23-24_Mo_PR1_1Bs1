namespace trojuhelník_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            //Vnější for cyklus pro vypisování řádků. Počet řádků je určen proměnou strana.
            for (int i = 0; i < strana; i++)
            {
                //Vnitřní for cyklus, který slouží pro vypisování sloupců (počet # v rámci řádku). S každým dalším řádkem bude o jeden # méně, proto se ověřuje strana - i, neboli strana mínus počet řádků.
                for (int j = 0; j < strana-i; j++)
                {
                    Console.Write('#');
                }
                //zalomení a konci řádku
                Console.WriteLine();
            }

        }
    }
}