using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soc_sit
{
    public class Comment
    {
        //Položky dané třídy
        public string content;
        public string author;

        //Kontruktor dané třídy
        public Comment(string obsah, string autor) 
        {
            content = obsah;
            author = autor;
        }
    }
}
