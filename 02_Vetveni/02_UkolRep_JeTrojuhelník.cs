namespace trojuhelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nacteno;

            Console.Write("Zadej stranu A: ");
            nacteno = Console.ReadLine();
            double stranaA = double.Parse(nacteno);

            Console.Write("Zadej stranu B: ");
            nacteno = Console.ReadLine();
            double stranaB = double.Parse(nacteno);

            Console.Write("Zadej stranu C: ");
            nacteno = Console.ReadLine();
            double stranaC = double.Parse(nacteno);

            // Sem přijde váš kód

            bool lzeSestavit = false;

            double max = Math.Max(stranaA, stranaB);
            max = Math.Max(max, stranaC);
            double dvejinestrany = stranaA + stranaB + stranaC - max;

            if (dvejinestrany >= max)
            {
                lzeSestavit = true;
            }

            if (lzeSestavit)
            {
                Console.WriteLine("Je to trojuhleník!");
            }

            
        }
    }
}