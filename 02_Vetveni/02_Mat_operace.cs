namespace mat_operace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menší a větší ze dvou čísel
            Console.WriteLine(Math.Max(8, 6));
            Console.WriteLine(Math.Min(4, 1));

            //Odmocnina (vypisuje v desetinném čísle)
            Console.WriteLine(Math.Sqrt(21));

            //Absolutní hodnota
            Console.WriteLine(Math.Abs(-5));

            //Mocnina
            Console.WriteLine(Math.Pow(1, 2));
            Console.WriteLine(Math.Pow(3, 16));

            //Pi a E
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
        }
    }
}