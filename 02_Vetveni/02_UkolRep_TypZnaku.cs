namespace typznaku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosím stistkni tlačítko!");
            char znak = Console.ReadKey().KeyChar;

            int cislo = znak;

            if (cislo >= 65 && cislo <= 90 || cislo >= 97 && cislo <= 122)
            {
                Console.WriteLine("Zadaný vstup je písmeno!");
            } else if (cislo >= 48 && cislo <= 57)
            {
                Console.WriteLine("Zadaný vstup je číslo!");
            } else
            {
                Console.WriteLine("Zadaný vstup je symbol!");
            }
        }
    }
}