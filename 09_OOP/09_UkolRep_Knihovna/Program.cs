namespace knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tady se uživatele ptáme na jednotlivé položky pro vytvoření objektu ze Třídy Library
            Console.WriteLine("Zadej mi název knihovny");
            string nazev = Console.ReadLine();
            Console.WriteLine("Zadej mi lokaci knihovny");
            string lokace = Console.ReadLine();

            //Vytvvoření objektu knihov ze třídy Library
            Library knihov = new Library(nazev, lokace);

            while (true)
            {
                Console.WriteLine("Pokud chceš přidat knihu zadej 1 \nPokud chceš vypsat knihy, dle roku vydání zadej 2");
                int volba = int.Parse(Console.ReadLine());
                switch(volba)
                {
                    case 1:
                        knihov = PridejKnihu(knihov);
                        break;
                    case 2:
                        VypisKnihyRok(knihov);
                        break;
                }

            }
           

        }

        static Library PridejKnihu(Library knihov)
        {
            //Dotazy na položky pro vytvoření objektů ze třídy Auhor a Book
            Console.WriteLine("Napiš mi název knihy");
            string kniha_nazev = Console.ReadLine();
            Console.WriteLine("Napiš mi rok vydání knihy");
            int kniha_rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš mi jméno autora");
            string autor_jmeno = Console.ReadLine();
            Console.WriteLine("Napiš mi rok narození autora");
            int autor_rok = int.Parse(Console.ReadLine());

            //Vytvoření nového objektu ze třídy Author
            Author novy_autor = new Author(autor_jmeno, autor_rok);

            //Vytvoření nového objektu ze třídy Book
            Book nova_kniha = new Book(kniha_nazev, kniha_rok, novy_autor);

            //Zavolání metody objektu knihov
            knihov.AddBook(nova_kniha);

            return knihov;
        }

        static void VypisKnihyRok(Library knihov)
        {
            Console.WriteLine("Zadej rok vydání, dle kterého chceš vypsat knihy");
            int rokvydani = int.Parse(Console.ReadLine());
            knihov.VypisKnihyRok(rokvydani);
        }
    }
}