namespace Zavod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delka zavodní dráhy
            int delka = 20;
            //Naplnění závodních drah
            string[] draha1 = NaplnPole(delka, "Z1");
            string[] draha2 = NaplnPole(delka, "Z2");
            //Výpis závodních drah
            VypisPole(draha1);
            VypisPole(draha2);
            //základní indexy závodníků
            int poziceZ1 = 0;
            int poziceZ2 = 0;
            Console.ReadKey();
            //Cyklus na opakování, dokud jeden závodník nedoběhne
            while(poziceZ1 != delka-1 && poziceZ2 != delka-1)
            {
                Console.Clear();
                //Vypočítání nové pozice závodníka i s ošteřením kontroly
                int novapozice1 = Novapozice(draha1, poziceZ1, delka);
                int novapozice2 = Novapozice(draha2, poziceZ2, delka);
                //Přepis pole dráhy s novou pozicí
                draha1 = PrepisPole(poziceZ1, novapozice1, draha1);
                draha2 = PrepisPole(poziceZ2, novapozice2, draha2);
                //Výpis drah
                VypisPole(draha1);
                VypisPole(draha2);
                Console.ReadKey();
                //přepis nové pozice závodníka
                poziceZ1 = novapozice1;
                poziceZ2 = novapozice2;
            }

        }

        static string[] PrepisPole(int star_pozice,int nova_pozice, string[] pole)
        {
            if(pole[nova_pozice] != pole[star_pozice])
            {
            pole[nova_pozice] = pole[star_pozice];
            pole[star_pozice] = "_";
            }
            return pole;
        }
        static string[] NaplnPole(int delka, string token)
        {
            string[] pole = new string[delka];
            pole[0] = token;
            for (int i = 1; i < delka; i++)
            {
                pole[i] = "_";
            }
            return pole;
        }

        static void VypisPole(string[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i]);
            }
            Console.WriteLine();
        }

        static int Novapozice(string[] pole, int pozice, int delka)
        {
            Random gen = new Random();
            int nova_pozice = pozice;
            int roz = gen.Next(0, 4);
            switch (roz)
            {
                case 0:
                    nova_pozice++;
                    break;
                case 1:
                    nova_pozice += 2;
                    break;
                case 2:
                    break;
                case 3:
                    nova_pozice--;
                    break;
            }
            if (nova_pozice < 0)
            {
                nova_pozice = 0;
            }
            if (nova_pozice >= delka)
            {
                nova_pozice = delka - 1;
            }
            return nova_pozice;
        }
    }
}