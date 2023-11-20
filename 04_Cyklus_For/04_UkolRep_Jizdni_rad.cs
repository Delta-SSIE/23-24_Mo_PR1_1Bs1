namespace jizdni_rad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hodiny = 5;
            int minuty = 42;

            for (int i = 0; i < 21; i++)
            {
                //Výpis, aby byl s nulou, pokud je hodin méně než 10
                if (hodiny < 10)
                {
                    Console.Write($"Autobus jede v 0{hodiny}:");
                } else
                {
                    Console.Write($"Autobus jede v {hodiny}:");
                }
                //Výpis, aby byl s nulou, pokud je minut méně než 10
                if (minuty < 10)
                {
                    Console.WriteLine($"0{minuty}");
                }
                else
                {
                    Console.WriteLine($"{minuty}");
                }

                //Zvýšení minut o 13, což je interval autobusů
                minuty += 13;
                //Pokud je minut více, či rovno 60, pak je třeba je převést na hodiny.
                if (minuty >= 60)
                {
                    minuty -= 60;
                    hodiny++;
                }
            }
        }
    }
}