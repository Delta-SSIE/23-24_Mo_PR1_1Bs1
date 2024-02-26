namespace Enum
{
    internal class Program
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }

        enum Pole
        {
            Voda,
            Lod,
            Zasah,
            Zasazena_lod
        }
        static void Main(string[] args)
        {
            Months aktu_mesic = Months.February;

            Console.WriteLine(aktu_mesic);

            int myNum = (int)Months.May;
            Console.WriteLine(myNum);

            Months pred_mesic = aktu_mesic - 1;
            Console.WriteLine(pred_mesic);

            Months nad_mesic = aktu_mesic + 1;
            Console.WriteLine(nad_mesic);



            Months mesic = Months.January;

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(mesic);
                mesic = mesic + 1;
            }

        }
    }
}