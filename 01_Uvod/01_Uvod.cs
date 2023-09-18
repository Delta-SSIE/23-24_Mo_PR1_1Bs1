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

            //Deklarace desetinného čísla
            float e = 1.526f;
            Console.WriteLine(e);

            //deklarace long
            long a = 1111111111111111;
            Console.WriteLine(a);

            //deklarace boolean
            bool b = false;
            Console.WriteLine(b);

            //převod dnů a hodin na minuty
            int d = 10;
            int h = 60;
            int m = 15;
            int vysledek = (((d * 24) + h) * 60) + m;
            Console.WriteLine("Když převedu " + d + " dnů a " + h + " " +
                "hodin na minuty a přičtu k tomu " + m + " " +
                "minut, tak mi vyjde " + vysledek + " minut!");

            //Vstup od uživatele
            Console.WriteLine("Zadej mi své jméno?");
            string jmenostudent = Console.ReadLine();
            Console.WriteLine("Student DELTY se jmenuje " + jmenostudent);

            //Vstup od uživatele s převodem na číslo
            Console.WriteLine("Kolik je ti let?");
            string vekstudent = Console.ReadLine();
            int vekstudenta = int.Parse(vekstudent);
            Console.WriteLine("Studentovi Delty je " + (vekstudenta+5));

            //Vstup od uživatele s převedením na číslo rovnou
            Console.WriteLine("Dej mi číslo ulice");
            int cisloulice = int.Parse(Console.ReadLine());
            Console.WriteLine(cisloulice);

            //Převaděč času na dotaz uživatele
            Console.WriteLine("Napiš mi počet dnů?");
            int dny = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš mi počet hodin?");
            int hodiny = int.Parse(Console.ReadLine());
            //Místo Parse použití convert
            Console.WriteLine("Napiš mi počet minut?");
            int minuty = Convert.ToInt32(Console.ReadLine());
            int vysledek2 = (((dny * 24) + hodiny) * 60) + minuty;
            Console.WriteLine("Když převedu " + dny + " dnů a " + hodiny + " " +
                "hodin na minuty a přičtu k tomu " + minuty + " " +
                "minut, tak mi vyjde " + vysledek2 + " minut!");
        }
    }
}