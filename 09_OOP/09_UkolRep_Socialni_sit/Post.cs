using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soc_sit
{
    public class Post
    {
        //Položky dané třídy, včetně položky comments, což je pole objektů třídy Comment
        public string title;
        public string content;
        public string author;
        public Comment[] comments;

        //Konstruktor dané třídy
        public Post()
        {
            Console.WriteLine("Napiš název příspěvku");
            title = Console.ReadLine();
            Console.WriteLine("Napiš příspěvek");
            content = Console.ReadLine();
            Console.WriteLine("Napiš své jmeno");
            author = Console.ReadLine();
            //pole comments se incializuje s velikostí 0
            comments = new Comment[0];
        }

        public void AddComment()
        {
            Console.WriteLine("Napiš komentář");
            string koment = Console.ReadLine();
            Console.WriteLine("Podepiš se");
            string jmeno = Console.ReadLine();
            //Zvětšení pole comments o 1.
            Array.Resize(ref this.comments, this.comments.Length + 1);
            //Přidání nové objektu z třídy Comment do pole comments
            this.comments[comments.Length - 1] = new Comment(koment, jmeno);
        }

        public void VypisKomentare()
        {
            //Výpis pole comments
            foreach(Comment komentar in comments)
            {
                Console.WriteLine($"Komentář: {komentar.content}; Napsal: {komentar.author}");
            }
        }
    }
}
