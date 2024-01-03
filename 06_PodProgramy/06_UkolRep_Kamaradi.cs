namespace kamaradi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Volání metody "Kamaradi" s dvěma argumenty
            Kamaradi("Anička", "Karel");
            Kamaradi("Blažej", "Jana");
            Kamaradi("Ruprecht", "Ignác");
        }

        //Metoda "Kamaradi", která očekává dva argumenty, které naplní parametry "kamarad1" a "kamarad2"
        static void Kamaradi(string kamarad1, string kamarad2)
        {
            Console.WriteLine($"Moji kamarádi jsou {kamarad1} a {kamarad2}");
        }
    }
}