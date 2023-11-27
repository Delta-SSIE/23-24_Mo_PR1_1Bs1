namespace dlouhe_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole o délce 5
            string[] slova = new string[5];

            //Průchod pole s deklarovanou délkou pro načítání hodnot do pole.
            for (int i = 0; i < slova.Length; i++)
            {
                //Dotazování na zadání hodnoty do pole a její načtení
                Console.WriteLine($"Zadej mi {i+1}.slovo");
                slova[i] = Console.ReadLine();
            }

            Console.WriteLine("Ze zadaných řetězců jsou alespoň 6-znakové tyto:");
            
            //cyklus pro průchod pole
            foreach (string slovo in slova)
            {
                //Kontrola u každého prvku pole zda je roven, či delší 6 znakům. Případně, že ano, tak jeho výpis!
                if (slovo.Length >= 6)
                {
                    Console.WriteLine(slovo);
                }
            }

        }
    }
}