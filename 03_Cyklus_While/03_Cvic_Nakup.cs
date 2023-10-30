namespace nakup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;
            double cel_cena = 0;
            int vyber = 0;
            int kusy = 0;

            do
            {
                Console.WriteLine("Pro výběr zboží stiskni příslušné číslo: houska (1); rohlík (2); chleba (3). Pro ukončení zadej 0!");
                while (!int.TryParse(Console.ReadLine(), out vyber))
                {
                    Console.WriteLine("Zadej číslo!");
                }
                Console.WriteLine("Kolik kusů daného zboží chceš?");
                while (!int.TryParse(Console.ReadLine(), out kusy))
                    {
                        Console.WriteLine("Zadej číslo!");
                    }
                switch (vyber)
                {
                    case 1:
                        cel_cena += (5.5*kusy);
                        pocet += kusy;
                        break;
                    case 2:
                        cel_cena += (3.5*kusy);
                        pocet += kusy;
                        break;
                    case 3:
                        cel_cena += (10*kusy);
                        pocet += kusy;
                        break;
                    case 0:
                        Console.WriteLine("Nákup byl ukončen!");
                        break;
                    default:
                        Console.WriteLine("Byl zadán neplatný vstup");
                        break;
                }
            } while (pocet <= 10 && vyber != 0);

            Console.WriteLine($"Celková cena nákup je {cel_cena} a bylo nakoupeno {pocet} kus/ů/y!");
        }
    }
}