namespace trojuhelnik_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            //Varianta 1. s podmínkou

            //Vnější cyklus pro vypsání řádků určených stranou 
            for (int i = 1; i <= strana; i++)
            {
                //Vnitřní cyklus se opakuje tolikrát kolik je strana, protože reálně chceme naplnit prostor čtverce, jen budeme řešit jestli se má vypsat mezera, nebo hash.
                for (int j = 0; j < strana; j++)
                {
                    //Pokud je j menší než strana - aktuální řádek, tak se napíše mezera, jinak hash
                    if (j < strana-i)
                    {
                        Console.Write(' ');
                    } else
                    {
                        Console.Write("#");
                    }  
                }
                //Zalomení řádku
                Console.WriteLine();
            }

            //Varianta 2. se dvěma for cykly
            Console.WriteLine();


            //Vnější cyklus pro vypsání řádků určených stranou 
            for (int i = 1; i <= strana; i++)
            {
                //Cyklus pro výpis mezer s každým průchodem vnějším cyklem je se opakuje mínkrát
                for (int j = 0; j < strana-i; j++)
                {
                    Console.Write(' ');
                }
                //Cyklus pro výpis hashů s každým průchodem se opakuje víckrát
                for (int n = 0; n < i; n++)
                {
                    Console.Write('#');
                }
                //zalomení na konci řádku
                Console.WriteLine();
            }
        }
    }
}