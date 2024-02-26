namespace karty_enum
{
    internal class Program
    {
        enum Karta
        {
            sedma = 7,
            osma,
            devítka,
            desítka,
            spodek,
            filek = 11,
            svršek,
            královna,
            eso
        }
        static void Main(string[] args)
        {
            Karta moje_karta = Karta.desítka;
            Console.WriteLine(moje_karta);

            moje_karta++;
            Console.WriteLine(moje_karta);

            moje_karta = Karta.eso;
            moje_karta++;
            Console.WriteLine(moje_karta);

            Karta A = Karta.eso;
            Karta B = Karta.eso;

            KdoJeVyssi(A, B);

        }

        static void KdoJeVyssi( Karta kartaA, Karta kartaB)
        {
            int a = (int) kartaA;
            int b = (int) kartaB;

            if (a == b)
            {
                Console.WriteLine("Karty mají stejnou hodnotu!");
            } else if (a > b) {
                Console.WriteLine($"{kartaA} je vyšší než {kartaB}");
            } else
            {
                Console.WriteLine($"{kartaB} je vyšší než {kartaA}");
            }
        }
    }
}