namespace Najdi_prvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17};
            int cislo = 0;
            while(true)
            {
                Console.WriteLine("Zadej číslo!");
                cislo = int.Parse(Console.ReadLine());

                //Cyklus pro průchod pole
                for (int i = 0; i < cisla.Length; i++)
                {
                    //Podmínka pro to, jestli dané číslo se rovná číslu načteném z pole
                    if (cisla[i] == cislo)
                    {
                        Console.WriteLine($"Čislo {cislo} se nachází v poli na indexu {i}");
                        //Číslo bylo nalezeno, nemá smysl pokračovat v cyklu, proto vyskočení z něj.
                        break;
                    }

                    //Pokud se dostaneme k poslednímu průchodu cyklem, tak se vypíše, že zadané číslo v něm není.
                    if(i == cisla.Length-1)
                    {
                        Console.WriteLine("Čislo není v tomto poli!");
                    }
                }

            }
        }
    }
}