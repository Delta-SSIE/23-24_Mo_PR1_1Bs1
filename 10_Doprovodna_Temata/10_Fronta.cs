namespace fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "MCA", "MBA", "BCA", "BBA", "BTech", "MTech" };
            //Incializace fronty s prvky z pole
            Queue<string> queue = new Queue<string>(courses);

            //Vypsání fronty
            foreach (string prvek in queue)
            {
                Console.WriteLine(prvek);
            }

            //Výpis počtu prvků z fronty
            Console.WriteLine(queue.Count());

            //Přidání prvku do fronty
            Queue<int> frontaCis = new Queue<int>();
            frontaCis.Enqueue(1);
            frontaCis.Enqueue(2);
            frontaCis.Enqueue(3);
            frontaCis.Enqueue(4);
            frontaCis.Enqueue(5);
            frontaCis.Enqueue(6);

            foreach (int prvek in frontaCis)
            {
                Console.WriteLine(prvek);
            }

            //Vyhození prvků z fronty (odebírá se od prvního prvku ve frontě)
            frontaCis.Dequeue();
            frontaCis.Dequeue();

            foreach (int prvek in frontaCis)
            {
                Console.WriteLine(prvek);
            }

            //Hledání ve frontě
            Console.WriteLine(frontaCis.Contains(3));
            Console.WriteLine(frontaCis.Contains(1));

            //Peek
            Console.WriteLine(frontaCis.Peek());
            Console.WriteLine(queue.Peek());


        }
    }
}