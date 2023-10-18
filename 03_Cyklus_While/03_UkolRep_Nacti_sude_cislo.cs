namespace Nacti_Sude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Původní hodnota, aby nám cyklus, aspoň jednou prošel
            int cislo = 1;
            
            //Podmínka cyklu je, že dokud po celočíselném dělení není zbytek 0, tak se opakuje
            while(cislo % 2 != 0)
            {
                //Načte nové číslo
                Console.WriteLine("Napiš mi číslo");
                cislo = int.Parse(Console.ReadLine());
            }
            //Výpis nakonec
            Console.WriteLine($"Napsal si sudé číslo {cislo} a nejbližší liché je {cislo+1}");
        }
    }
}