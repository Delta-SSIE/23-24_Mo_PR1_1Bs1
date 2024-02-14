namespace Projekt_Lode
{
    internal class Program
    {
        /*
         * 0 - voda
         * 1 - jedničková loď
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi rozměr hrací plochy?");
            int rozmer = OsetriCislo();

            int[,] hrac_pole = Vytvorpole(rozmer);
            int[,] pc_pole = Vytvorpole(rozmer);

            hrac_pole = VlozLode(hrac_pole, 1, 5, 0);
            pc_pole = VlozLode(pc_pole, 1, 5, 1);
            VypisPole(hrac_pole);
            VypisPole(pc_pole);
        }

        static void VypisPole(int[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int OsetriCislo()
        {
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Neplatný vstup, zadej číslo!");
            }
            return cislo;
        }

        static int[,] VlozLode(int[,] pole, int typ_lode, int pocet_lodi, int hrac)
        {
            int x = 0;
            int y = 0;
            Random generator = new Random();
            for (int i = 0; i < pocet_lodi; i++)
            {
                bool podminka = true;
                while (podminka)
                { 
                if (hrac == 0) { 
                        Console.WriteLine("Zadej souřadnici X, kam chceš položit loď");
                        x = OsetriCislo();
                        Console.WriteLine("Zadej souřadnici y, kam chceš položit loď");
                        y = OsetriCislo();
                    } else
                    {
                        x = generator.Next(0, pole.GetLength(1));
                        y = generator.Next(0, pole.GetLength(0));
                    }
                    if ((x >= 0 && x < pole.GetLength(1))&&(y >= 0 && y < pole.GetLength(0)))
                    {
                        if (pole[y,x] == 0)
                        {
                            podminka = false;
                        }
                        else
                        {
                            if (hrac == 0)
                            {
                                Console.WriteLine("Neplatný vstup, již je na pozici loď!");
                            }
                            
                        }
                    } else
                    {
                        Console.WriteLine("Neplatný vstup, mimo rozměr pole!");
                    }
                }
                pole[y,x] = typ_lode;
            }

            return pole;

        }

        static int[,] Vytvorpole(int rozmer)
        {
            int[,] pole = new int[rozmer, rozmer];

            for (int i = 0; i < rozmer; i++)
            {
                for (int j = 0; j < rozmer; j++)
                {
                    pole[i, j] = 0;
                }
            }
            return pole;
        }
    }
}