namespace Sazkovy_ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sportka = new int[] { 9, 5, 6, 1, 5, 6 };
            int uhadlacisla = 0;

            for (int i = 0; i < sportka.Length; i++)
            {
                Console.WriteLine($"Zadej mi {i+1}.číslo");
                int zadanecislo = int.Parse(Console.ReadLine());

                if (sportka[i] == zadanecislo)
                {
                    uhadlacisla++;
                }
            }

            Console.WriteLine($"Výhra je {uhadlacisla*10*uhadlacisla}");
        }
    }
}