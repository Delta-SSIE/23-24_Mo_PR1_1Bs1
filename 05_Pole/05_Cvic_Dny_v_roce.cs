namespace Dny_v_roce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dny = { "pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle" };
            string[] mesice = { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };
            int pocitadlo_den = 0;

            for (int i = 0; i < mesice.Length; i++)
            {
                for (int n = 1; n < 31; n++)
                {
                    if (pocitadlo_den == 7)
                    {
                        pocitadlo_den = 0;
                    }
                    Console.WriteLine($"{n}-{dny[pocitadlo_den]}-{mesice[i]}");
                    pocitadlo_den++;
                }

            }
        }
    }
}