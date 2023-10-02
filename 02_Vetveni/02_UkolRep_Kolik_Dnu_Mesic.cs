namespace kolik_dnu_ma_mesic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej měsíc pomocí čísla 1–12");
            int mesic = int.Parse(Console.ReadLine());
            
            if (mesic == 2)
            {
                Console.WriteLine("Počet dnů daného měsíce je 28!");
            } //Logický opetátor OR (nebo) vyznačen značkami || (alt+W)
            else if (mesic == 4 || mesic == 6 || mesic == 9 || mesic == 11)
            {
                Console.WriteLine("Počet dnů daného měsíce je 30!");
            }
            else
            {
                Console.WriteLine("Počet dnů daného měsíce je 31!");
            }

            Console.ReadKey();
        }
    }
}