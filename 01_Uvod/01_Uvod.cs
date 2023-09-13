namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tohle je komentář – kód následující vypíše "Ahoj světe!" do konzole!
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Ahoj třído!");

            //Deklarace proměné
            int vek = 5;
            string jmeno = "Honza";

            //Deklarace proměné a vložení hodnoty na novém řádku
            int cislopasu;
            cislopasu = 1;

            //Výpis hodnot proměných
            Console.WriteLine(vek);
            Console.WriteLine(jmeno);
            Console.WriteLine(cislopasu);

            //Výpis hodnot proměných (více najednou)
            Console.WriteLine(jmeno + " " + vek + " " + cislopasu);

            //Součet proměných jednohot typu (s výpisem)
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

        }
    }
}