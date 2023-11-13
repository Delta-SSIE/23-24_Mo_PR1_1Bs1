namespace prevod_cislo_znak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Základní slovo ze kterého se vyberou znaky, které se budou převádět na čísla.
            string slovo = "Ahoj";

            //Konvertování znaku na 1 indexu v stringu na číslo.
            int a = Convert.ToInt32(slovo[1]);

            //Výpis čísla
            Console.WriteLine(a);

            //Konvertování čísla na char
            char b = Convert.ToChar(a);

            //Výpis znaku
            Console.WriteLine(b);
        }
    }
}