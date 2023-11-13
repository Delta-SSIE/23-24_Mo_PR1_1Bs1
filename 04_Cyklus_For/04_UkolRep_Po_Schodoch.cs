namespace po_schodoch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patra;

            Console.WriteLine("Zadej počet pater");
            
            while(!int.TryParse(Console.ReadLine(),out patra))
            {
                Console.WriteLine("Zadej číslo!");
            }

            Console.Clear();

            for (int i = 1; i <= patra; i++)
            {
                for (int n = 0; n < i; n++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}