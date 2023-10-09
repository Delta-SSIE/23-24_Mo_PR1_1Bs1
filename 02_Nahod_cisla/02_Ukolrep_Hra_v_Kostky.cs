namespace hra_v_kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoď kostkou!");
            Console.ReadKey();

            //Generátor náhodného čísla
            Random kostka = new Random();

            int hod = kostka.Next(1, 7);
            int hodsouper = kostka.Next(1, 7);

            if (hod == hodsouper)
            {
                Console.WriteLine($"Remíza: {hod}:{hodsouper}");
            } else if (hod < hodsouper)
            {
                Console.WriteLine($"Prohral jsi, {hod}:{hodsouper}");
            } else
            {
                Console.WriteLine($"Vyhrál jsi, {hod}:{hodsouper}");
            }
        }
    }
}