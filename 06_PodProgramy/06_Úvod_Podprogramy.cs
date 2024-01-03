namespace podprogramy_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Zavolání metody "Pozdrav" s argumenty: i a konkrétními stringy
                Pozdrav(i, "Petr", "Blažek");
            }

            for (int i = 0; i < 10; i++)
            {
                //Zavolání metody je v rámci výpisu, protože metoda "Nasob" vrací číselné hodnoty
                Console.WriteLine(Nasob(i, i * i));
            }

        }

        //Metoda "Pozdrav" s třemi parametry (int a 2x string)
        static void Pozdrav(int cislo, string jmeno, string prijmeni)
        {
            Console.WriteLine($"Hello, {cislo}. {jmeno} {prijmeni}");
        }

        //Metoda "Nasob" s dvěma parametry. Nutné si povšimnout "int" místo "void", protože metoda vrací hodnotu!
        static int Nasob(int x, int y)
        {
            //return pro návrat hodnoty z metody.
            return x * y;
        }
    }
}