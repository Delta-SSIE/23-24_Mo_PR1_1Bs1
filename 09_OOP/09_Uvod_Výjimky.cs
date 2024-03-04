namespace vyjimka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] banka = { 120, 50, 120, 50, 150 };
            Console.WriteLine("Zadej mi index tvého účtu!");
            int i = 0;

            try
            {
                i = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Zadal jsi špatný datový typ!");
            }

            try
            {
                Console.WriteLine(banka[i]);
            } catch
            {
                i = banka.Length - 1;
                Console.WriteLine(banka[i]);
            }
        }
    }
}