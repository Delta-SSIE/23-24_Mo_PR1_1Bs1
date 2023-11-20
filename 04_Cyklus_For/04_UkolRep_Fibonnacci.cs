namespace fibonnacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Kolik Fibonacciho čísel chceš spočítat: ");
            n = int.Parse(Console.ReadLine());

            int predchozi = 1;
            int cislo = 1;
            int starypredchozi;

            Console.Write("1 1 ");
            for (int i = 3; i < n; i++)
            {
                starypredchozi = predchozi;
                predchozi = cislo;
                cislo = predchozi + starypredchozi;
                Console.Write(cislo + " ");
                
            }
        }
    }
}