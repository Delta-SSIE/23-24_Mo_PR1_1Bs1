namespace nadprumerne_hodnoty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Základní proměné, které budeme v rámci programu používat!
            int pocetcisel = 6;
            int soucet = 0;
            int[] cisla = new int[pocetcisel];

            //For cyklus pro načtení hodnot do pole a zvýšení celkového součtu v čísel.
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine("Zadej číslo");
                cisla[i] = int.Parse(Console.ReadLine());
                soucet += cisla[i];
            }

            //Výpočet průměru všech zadaných hodnot
            double prumer = soucet / pocetcisel;

            //Vyčištění dispeleje
            Console.Clear();
            Console.WriteLine("Zde jsou nadprůměrné hodnoty:");
            //Výpis hodnot z pole, které jsou vyšší či rovno průměru
            foreach (int a in cisla)
            {
                if(a >= prumer)
                {
                    Console.WriteLine(a);
                }
            }




        }
    }
}