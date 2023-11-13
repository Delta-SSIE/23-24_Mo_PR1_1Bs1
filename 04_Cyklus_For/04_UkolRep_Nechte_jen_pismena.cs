namespace nechte_pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Jean-Luc, you should inform no. 1 and then go and see what happened at 8:30PM!";
            int a;

            //For cyklus, který se bude opakovat dle délky stringu 'text'
            for (int i = 0; i < text.Length; i++)
            {
                //Konvertování znaku na 'i' indexu na číslo.
                a = Convert.ToInt32(text[i]);

                //Podmínka, kde se ověřuje jestli je znak v intervalu (viz. velká písmena mají kódy 65-90 a malá 97-122)
                if ((a > 64 && a < 91) || (a < 123 && a >96))
                {
                    //Výpis znaku s konverzí z čísla!
                    Console.Write(Convert.ToChar(a));
                }
            }
        }
    }
}