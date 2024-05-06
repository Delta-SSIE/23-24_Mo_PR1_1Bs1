namespace zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {
                "MCA",
                "BCA",
                "BBA",
                "MBA",
                "MTech"
            };

            //Incializace zásobníku naplněného prvky z pole
            Stack<string> zasobnik_Jmen = new Stack<string>(str);

            //Výpis počtu prvků v zásobníku
            Console.WriteLine(zasobnik_Jmen.Count());

            //Výpis zásobniku
            foreach (string prvek in zasobnik_Jmen)
            {
                Console.Write(prvek + " ");
            }
            Console.WriteLine();

            //Inicializace prázdného zásobníku
            Stack<string> zasAdres = new Stack<string>();

            //Vkládání prvků do zásobníku
            zasAdres.Push("Kamenická 123");
            zasAdres.Push("Lidická 123");
            zasAdres.Push("Faustova 666");

            foreach (string prvek in zasAdres)
            {
                Console.WriteLine(prvek + " ");
            }

            //Odstranění prvků ze zásobníku (vyhazují se prvky od posledního přidaného)
            zasAdres.Pop();
            zasAdres.Pop();
            foreach (string prvek in zasAdres)
            {
                Console.WriteLine(prvek + " ");
            }

            //Zjištění, co je první prvek v zásobníku
            Console.WriteLine(zasAdres.Peek());
            Console.WriteLine(zasobnik_Jmen.Peek());

            //Smazaní všech prvků v zásobníku
            zasAdres.Clear();


        }
    }
}