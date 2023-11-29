namespace balicek_karet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barvy = { "srdce", "kule", "žaludy", "listy" };
            string[] vysky = { "sedma", "osma", "devítka", "desítka", "spodek", "svršek", "král", "eso" };

            string[] balicek = new string[32];

            int pocetkaret = 0;
            for (int i = 0; i < barvy.Length; i++)
            {
                for (int n = 0; n < vysky.Length; n++)
                {
                    balicek[pocetkaret] = barvy[i] + " - " + vysky[n];
                        pocetkaret++;
                }
            }

            foreach (string karta in balicek)
            {
                Console.WriteLine(karta);
            }
        }
    }
}