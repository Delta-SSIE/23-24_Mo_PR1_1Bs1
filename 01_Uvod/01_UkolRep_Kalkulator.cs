namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odchycení vstupu od uživatele – Vybíráme float/double pro číslo s desetinou
            Console.WriteLine("Zadej mi 1. číslo: ");
            double prvnicislo = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej mi 2. číslo: ");
            double druhecislo = double.Parse(Console.ReadLine());

            //Provedení matematických operací
            Console.WriteLine("Součet čísel je " + (prvnicislo + druhecislo));
            Console.WriteLine("Rozdíl čísel je " + (prvnicislo - druhecislo));
            Console.WriteLine("Součin čísel je " + (prvnicislo * druhecislo));
            Console.WriteLine("Podíl čísel je " + (prvnicislo / druhecislo));

        }
    }
}