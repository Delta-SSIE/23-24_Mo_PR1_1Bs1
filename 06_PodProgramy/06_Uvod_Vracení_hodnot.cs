namespace kamaradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metoda NactiCislo vrací int, který se uloží do proměných
            int a = NactiCislo();
            int b = NactiCislo();

            Console.WriteLine(a+b);


        }

        static int NactiCislo()
        {
            int cislo = 0;
            Console.WriteLine("Napiš mi číslo");
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Tohle není číslo, zkus to znovu!");
            }
            //vrácení hodnoty uložené v proměné číslo
            return cislo;
        }
    }
}