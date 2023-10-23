namespace Padne_seskta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random kostka = new Random();
            //Základní údaje a proměné 
            //Počet hodů:
            float hody = 0;
            //Počet hozených šestek:
            float sestky = 0;
            //Počet hodů k dosažení šestky v daném kole:
            int p_hody_kolo = 0;
            //Maximální počet hodů k dosažení šestky:
            int max_hodu = 0;
            //Proměná pro opakování.
            bool start = true;

            //Cyklus pro opakování hodů
            while (start)
            {
                //Do While cyklus pro házení 1000 šestek
                do
                {
                    //zvýšení počtu celkových hodů o 1
                    hody++;
                    //Podmínka, která řeší zda padla šestka!
                    if(kostka.Next(1, 7) == 6)
                    {
                        //Zvyšení počtu padlých šestek
                        sestky++;
                        //Podmínka pro hledání maxima počtu hodů k hození šestky
                        if (max_hodu < p_hody_kolo)
                        {
                            max_hodu = p_hody_kolo;
                        }
                        //Vynulování počtu hodů v daném kole
                        p_hody_kolo = 0;
                    } else
                    {
                        //Pokud není šestka nalezena, tak se hází znovu!
                        p_hody_kolo++;
                    }
                } while (sestky < 1000);
                //Výpis
                Console.WriteLine($"Průměrný počet hodů na hození šestky {hody/sestky} a největší počet hodů na hození šestky je {max_hodu}");
                //Vynulování hodnot
                sestky = 0;
                hody = 0;
                max_hodu = 0;
                //Opakování cyklu
                Console.WriteLine("Chceš znova házet, pokud ne stiskni 'N'");
                char stisk = Console.ReadKey().KeyChar;
                if (stisk == 'N' || stisk == 'n')
                {
                    start = false;
                }
            }
        }
    }
}