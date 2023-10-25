namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo");
            string txt = Console.ReadLine();
            int cislo;

            //Tryparse pokusí proměnou txt převést do proměné cislo.
            if (int.TryParse(txt, out cislo))
            {
                Console.WriteLine("Zadal jsi číslo");
            } else
            {
                Console.WriteLine("Zadal jsi něco jiného než číslo");
            }


            //TryParse v cyklu, "!" označuje negaci výrazu, dokud tedy neplatí, tak se bude cyklus opakovat!
            while (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Zadej číslo znovu!");
            }

        }
    }
}