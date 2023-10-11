namespace obesenec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hra oběšenec – slovo o třech písmenech a 3 se může uživatel splést

            int chyba = 0;
            int uhadnutepismeno = 0;
            Console.WriteLine("napiš tří písmené slovo");
            string slovo = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Hádej písmeno!");
                char pismeno = Console.ReadKey().KeyChar;

                if (pismeno == slovo[0])
                {
                    uhadnutepismeno++;
                    Console.WriteLine("Správně!");
                } else if (pismeno == slovo[1])
                {
                    uhadnutepismeno++;
                    Console.WriteLine("Správně!");
                } else if (pismeno == slovo[2])
                {
                    uhadnutepismeno++;
                    Console.WriteLine("Správně!");
                } else
                {
                    chyba++;
                    Console.WriteLine("Špatně!");
                }

                if (chyba == 3 || uhadnutepismeno == 3)
                {
                    break;
                }
            }

            if(chyba == 3)
            {
                Console.WriteLine("Prohra!");
            } else
            {
                Console.WriteLine("Výhra!");
            }
       
        }
    }
}