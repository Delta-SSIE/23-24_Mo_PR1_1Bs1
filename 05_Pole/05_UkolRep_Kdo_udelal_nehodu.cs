namespace Kdo_udelal_nehodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] jizdy = {
            247,
            135,
            15,
            23,
            428,
            63,
            26,
            7
        };

            string[] ridici = {
            "Petr",
            "Pavel",
            "Jaroslav",
            "Pavel",
            "Jaroslav",
            "Petr",
            "Pavel",
            "Petr"
        };

            int prestupek = 401;

            for (int i = 0; i < jizdy.Length; i++)
            {
                if (prestupek <= jizdy[i])
                {
                    Console.WriteLine($"Přestupek učinil řidič jedoucí rychlostí {jizdy[i]}, který se jmenuje {ridici[i]}");
                }
            }

        }
    }
}