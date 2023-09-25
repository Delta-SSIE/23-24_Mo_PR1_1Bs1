namespace podminka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první číslo: ");
            int x = int.Parse(Console.ReadLine());
            //Vymaže obsah konzole
            Console.Clear();
            Console.Write("Zadej druhé číslo: ");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();

            //Podmínka, pokud je x větší než y.
            if(x > y)
            {
                Console.WriteLine("První číslo je větší než druhé!");
            } else
            {
                Console.WriteLine("Druhé číslo je větší než první!");
            }

            //Podmínka zohedňující, když se x a y rovnají
            if (x > y)
            {
                Console.WriteLine("První číslo je větší než druhé!");
            }
            else if(x == y)
            {
                Console.WriteLine("Čísla jsou si rovna!");
            } else
            {
                Console.WriteLine("Druhé číslo je větší než první!");
            }

            //Logické operátory

            //And celočíselné dělení dvěma čísly

            if (x % 2 == 0 && x % 3 == 0)
            {
                Console.WriteLine("První číslo je celočíselně dělitelné dvěma a třema!");
            }

        }
    }
}