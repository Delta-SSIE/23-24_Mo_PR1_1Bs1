namespace Serad_4_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš 1. číslo");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš 2. číslo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš 3. číslo");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš ´4. číslo");
            int d = int.Parse(Console.ReadLine());

            int max = Math.Max(a, b);
            max = Math.Max(max, c);
            max = Math.Max(max, d);

            int min = Math.Min(a, b);
            min = Math.Min(min, c);
            min = Math.Min(min, d);

            int A = 0;
            int B = 0;

            if (a != min && a != max)
            {
                if (A == 0)
                {
                    A = a;
                } else
                {
                    B = a;
                }
            }
            if (b != min && b != max)
            {
                if (A == 0)
                {
                    A = b;
                }
                else
                {
                    B = b;
                }
            }
            if (c != min && c != max)
            {
                if (A == 0)
                {
                    A = c;
                }
                else
                {
                    B = c;
                }
            }
            if (d != min && d != max)
            {
                if (A == 0)
                {
                    A = d;
                }
                else
                {
                    B = d;
                }
            }

            int treticislo = Math.Max(A, B);
            int druhecislo = Math.Min(A, B);

            Console.WriteLine($"Řada čísel od nejvyššího je: {max} {treticislo} {druhecislo} {min}");

        }
    }
}