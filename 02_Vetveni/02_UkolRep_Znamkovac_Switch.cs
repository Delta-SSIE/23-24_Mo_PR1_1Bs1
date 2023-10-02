using System.Runtime;

namespace znamkovac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi procenta z testu a já ti dám známku (0–100)");
            int procenta = int.Parse(Console.ReadLine());

            switch (procenta)
            {
                case > 100:
                    Console.WriteLine("Zadal jsi hloupost!");
                    break;
                case > 83:
                    Console.WriteLine("Dostal jsi jedničku");
                    break;
                case > 67:
                    Console.WriteLine("Dostal jsi dvojku");
                    break;
                case > 50:
                    Console.WriteLine("Dostal jsi trojku!");
                    break;
                case > 33:
                    Console.WriteLine("Dostal jsi čtyřku!");
                    break;
                case >= 0:
                    Console.WriteLine("Dostal jsi pětku!");
                    break;
                default:
                    Console.WriteLine("Zadal jsi nesmysl!");
                    break;
            }
        }
    }
}