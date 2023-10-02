namespace dny_v_tydnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš mi pořadí dnu v týdnu (1–7): ");
            int den = int.Parse(Console.ReadLine());

            switch (den)
            {
                case 1:
                    Console.WriteLine("Pondělí");
                    break;
                case 2:
                    Console.WriteLine("Úterý");
                    break;
                case 3:
                    Console.WriteLine("Středa");
                    break;
                case 4:
                    Console.WriteLine("Čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Pátek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Neděle");
                    break;
            }

        }
    }
}