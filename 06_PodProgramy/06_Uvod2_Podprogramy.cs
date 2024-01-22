namespace Uvod_Podprogramy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Pozdrav();
            }
            */

            /*
            Console.WriteLine("Napiš mi číslo X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš mi číslo Y");
            int y = int.Parse(Console.ReadLine());
            Scitani(x,y);
            Scitani(10, 12);
            */

            /*
            Osoba("Lukáš", 22);
            Osoba("David", 12);
            Osoba("Ludmila", 80);
            */

            /*
            int a = Vstup();
            int b = Vstup();
            Scitani(a, b);
            */

            Console.WriteLine($"Osoba se jmenuje {Jmeno()} a její věk je {Vek()}");




        }

        static string Jmeno()
        {
            Console.WriteLine("Napiš mi své jméno");
            string jmeno = Console.ReadLine();
            return jmeno;
        }


        static int Vek()
        {
            Console.WriteLine("Napiš mi svůj věk");
            int cislo = int.Parse(Console.ReadLine());
            return cislo;
        }
        static int Vstup()
        {
            Console.WriteLine("Napiš mi číslo");
            int cislo = int.Parse(Console.ReadLine());
            return cislo;
        }

        static void Pozdrav()
        {
            Console.WriteLine("Ahoj!");
        }

        static void Scitani(int cisloA, int cisloB)
        {
            Console.WriteLine(cisloA + cisloB);
        }

        static void Osoba(string jmeno, int vek)
        {
            Console.WriteLine($"Osoba se jmenuje {jmeno} a její věk je {vek}");
        }
    }
}