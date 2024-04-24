using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_cok
{
    internal class Tabulka
    {
        private string znacka;
        private int hmotnost;
        private string druh;

        public string Znacka
        {
            get { return znacka; }
            set { this.znacka = value; }
        }

        public int Hmotnost
        {
            get { return hmotnost; }
            set
            {
                if(value <= 1000)
                {
                    this.hmotnost = value;
                }
            }
        }

        public string Druh
        {
            get { return druh; }
            set
            {
                if(value == "Hořká" || value == "Bílá"  || value == "Mléčná")
                {
                    this.druh = value;
                }
            }
        }

        public int Odlom()
        {
            int zlomena_cast = 0;
            if (hmotnost >= 10)
            {
                zlomena_cast = hmotnost / 2;
                hmotnost -= zlomena_cast;
            } else
            {
                zlomena_cast = hmotnost;
                hmotnost = 0;
            }
            return zlomena_cast;
        }
    }
}
