namespace pod_soucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186 };

            //Proměná pro úkladání součtu hodnot
            int soucet = 0;

            //for cyklus pro průchod pole 
            for (int i = 0; i < cisla.Length; i++)
            {
                //if pro ověření, že číslo načtené v rámci průchodu je v intervalu
                if (cisla[i] <= 10 && cisla[i] >= -10)
                {
                    //přičtení čísla k součtu
                    soucet += cisla[i];
                }
            }

            //výpis součtu
            Console.WriteLine(soucet);
        }
    }
}