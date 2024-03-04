namespace datab_najem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] byty = { "", "Procházkovi", "Novotní", "Jedlička", "Jůzovi", "Zelená", "Zbyšek", "Starochovi", "Mladěnová" };

            Console.WriteLine("Služba \"Výpis rodin\" vám odpoví na otázku, kdo bydlí v našem domě. Vložte číslo bytu, které chcete znát, nebo 0 pro ukončení aplikace.");
            do
            {
                Console.WriteLine();
                Console.Write("Zadejte číslo bytu: ");

                string prikaz = Console.ReadLine();

                if (prikaz == "0")
                    break;

                try { 
                int cisloBytu = int.Parse(prikaz);
                Console.WriteLine($"V bytě číslo {cisloBytu} bydlí {byty[cisloBytu]}.");
                }
                catch
                {
                    Console.WriteLine("Tento byt se v domě nenachází.");
                }
            } while (true);

            Console.WriteLine();
            Console.WriteLine("Děkujeme za použití naší služby.");
        }
    }
}