namespace cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetlich = 0;
            int pocetdsudych = 0;
            int nejmensi = 0;
            int nejvetsi = 0;
            int vstup = 0;

            do
            {
                Console.WriteLine("Zadej mi číslo, pokud chceš zadávání ukončit vlož 0");
                while(!int.TryParse(Console.ReadLine(),out vstup))
                {
                    Console.WriteLine("Zadej číslo");
                }
                if (vstup > nejvetsi)
                {
                    nejvetsi = vstup;
                } else if ((vstup < nejmensi || nejmensi == 0) && vstup != 0)
                {
                    nejmensi = vstup;
                }

                if (vstup % 2 == 0 && vstup != 0)
                {
                    pocetdsudych++;
                } else if (vstup != 0)
                {
                    pocetlich++;
                }
            } while (vstup != 0);

            Console.WriteLine($"Největší číslo je {nejvetsi}! \nNejmenší číslo je {nejmensi}.\nPočet sudých čísel je {pocetdsudych}.\nPočet lichých čísel je {pocetlich}.");
        }
    }
}