namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření nového souboru
            // FileStream fs = File.Create(@"../../../text.txt");
            //Existence souboru
            if (File.Exists(@"../../../text.txt"))
            {
                Console.WriteLine("File is created.");
            }
            else
            {
                Console.WriteLine("File is not created.");
            }


            //Zapsaní textu do souboru
            File.WriteAllText(@"../../../text.txt", "Hello World!");

            //Čtení ze souboru
            Console.WriteLine(File.ReadAllText(@"../../../text.txt"));

            //StreamWriter zápis do nového souboru
            using (StreamWriter sw = new StreamWriter(@"../../../text2.txt"))
            {
                sw.WriteLine("První řádek");
                sw.WriteLine("Druhý řádek");
                sw.WriteLine("Konec");
                sw.Flush();
            }

            //StreamWriter připsaná do souboru
            using (StreamWriter sw = new StreamWriter(@"../../../text2.txt", true))
            {
                sw.WriteLine("Nový řádek");
                sw.Flush();
            }

            //StreamReader
            using(StreamReader sr = new StreamReader(@"../../../text2.txt"))
            {
                string s;
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}