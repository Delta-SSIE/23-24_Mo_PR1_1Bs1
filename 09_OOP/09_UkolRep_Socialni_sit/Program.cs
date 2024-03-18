namespace Soc_sit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaruji pole statusy, které je pole objektů z třídy Post na začátku má nulovou velikost.
            Post[] statusy = new Post[0];

            //Nekonečný cyklus jako menu s voláním metod
            while (true)
            {
                Console.WriteLine("Pro výpis statusů zadej 1\nPro napsaní přispěvku zadej 2\nPro napsání komentáře zadej 3");
                int volba = int.Parse(Console.ReadLine());
                switch(volba)
                {
                    case 1:
                        VypisStatusy(statusy);
                        break;
                    case 2:
                        statusy = AddPost(statusy);
                        break;
                    case 3:
                        statusy = NapisKomentar(statusy);
                        break;

                }
            }

        }

        //Metoda pro napsání komentáře, která přijmá a vrací pole objektů z třídy Post
        static Post[] NapisKomentar(Post[] statusy)
        {
            //For cyklus pro vypsání všech objektů v poli statusy
            for (int i = 1; i <= statusy.Length; i++)
            {
                Console.WriteLine($"{i}. Status se jmenuje {statusy[i-1].title}");
            }
            //Zadání pořadového čísla příspěvku, ke kterému chceme napsat komentář!
            Console.WriteLine("Zadej číslo statusu, který chceš komentovat");
            int cislo = int.Parse(Console.ReadLine());
            //Na indexu v poli zavoláme u daného objektu (který je na tom indexu) metodu AddComment z Třídy Post
            statusy[cislo-1].AddComment();
            return statusy;
        }

        static Post[] AddPost(Post[] statusy)
        {
            //Vytvoříme nový objekt z třídy Post - ten se vytvoří pomocí konstruktoru dané třídy
            Post novy_prispevek = new Post();
            //Zvětšíme pole statusy o 1
            Array.Resize(ref statusy, statusy.Length + 1);
            //Přidáme na nový index nový objekt z Třídy Post
            statusy[statusy.Length - 1] = novy_prispevek;
            return statusy;
        }

        static void VypisStatusy(Post[] statusy)
        {
            //Procházíme pole statusy a vypisujeme jednotlivé objekty (jejich položky) a u každého objektu voláme metodu VypisKomentar z třídy Post
            foreach (Post post in statusy)
            {
                Console.WriteLine($"{post.title}\n{post.content}\nNapsal:{post.author}");
                post.VypisKomentare();
                Console.WriteLine();
            }
        }
    }
}