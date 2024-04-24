namespace tab_cok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabulka ma_tabulka = new Tabulka();
            ma_tabulka.Druh = "Mléčná";
            ma_tabulka.Znacka = "Orion";
            ma_tabulka.Hmotnost = 1000;

            Console.WriteLine($"Má čokoláda je značky {ma_tabulka.Znacka} a je to druh {ma_tabulka.Druh} a má hmotnost {ma_tabulka.Hmotnost}");

            while(ma_tabulka.Hmotnost != 0)
            {
                int odlomeno = ma_tabulka.Odlom();
                Console.WriteLine($"Z mé tabulky bylo odlomeno {odlomeno}");
            }
        }
    }
}