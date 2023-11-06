namespace Secti_N_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proměná, která slouží k uložení počtu opakování cyklus
            int n;
            //Proměná pro načítání součtu zadaných čísel
            int soucet = 0;

            //TryParse pro odchytnutí toho, aby uživatel zadal pouze číslo! Zde se program ptá na počet opakování cyklu.
            Console.WriteLine("Zadej kolik čísel budeš chtít zadat");
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Zadej opravdu číslo!");
            }

            //For cyklus, kdy v podmínce se i porovnává s proměnou n, která v sobě nese informaci o počtu opakování danéhé cyklu.
            for (int i = 0; i < n; i++)
            {
                //Proměná pro načtení čísla v rámci průchodu cyklem.
                int a;
                //TryParse pro odchycení chyby při zadaní uživatele. 
                Console.WriteLine("Zadej číslo a já ho přičtu k součtu!");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Zadej opravdu číslo!");
                }
                //Přičtení zadaného čísla k součtu (proměné součet)
                soucet += a;
            }

            //Výpis
            Console.WriteLine($"Součet zadaných čísel je {soucet}");
        }
    }
}